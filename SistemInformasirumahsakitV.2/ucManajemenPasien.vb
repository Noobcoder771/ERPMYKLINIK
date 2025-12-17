Imports MySql.Data.MySqlClient

Public Class ucManajemenPasien

    Private Sub ucManajemenPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AturGrid() ' 
        Call TampilDataPasien("")
    End Sub

    Sub AturGrid()
        dgvPasien.AutoGenerateColumns = False


        dgvPasien.Columns(0).DataPropertyName = "no_rm"
        dgvPasien.Columns(0).ReadOnly = True
        dgvPasien.Columns(0).DefaultCellStyle.BackColor = Color.LightGray

        dgvPasien.Columns(1).DataPropertyName = "nama_pasien"

        dgvPasien.Columns(2).DataPropertyName = "jenis_kelamin"

        dgvPasien.Columns(3).DataPropertyName = "no_telepon"

        dgvPasien.Columns(4).DataPropertyName = "tgl_registrasi"
        dgvPasien.Columns(4).ReadOnly = True ' 
    End Sub

    Sub TampilDataPasien(keyword As String)
        Try
            Call BukaKoneksi()
            Dim query As String

            If keyword = "" Then
                query = "SELECT no_rm, nama_pasien, jenis_kelamin, no_telepon, tgl_registrasi FROM tbl_pasien ORDER BY tgl_registrasi DESC LIMIT 50"
            Else
                query = "SELECT no_rm, nama_pasien, jenis_kelamin, no_telepon, tgl_registrasi FROM tbl_pasien WHERE no_rm LIKE '%" & keyword & "%' OR nama_pasien LIKE '%" & keyword & "%'"
            End If

            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvPasien.DataSource = dt

        Catch ex As Exception
            MsgBox("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call TampilDataPasien(txtcari.Text)
    End Sub


    Private Sub dgvPasien_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPasien.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim BarisKe As Integer = e.RowIndex
            Dim KolomKe As Integer = e.ColumnIndex

            If dgvPasien.Rows(BarisKe).Cells(0).Value Is Nothing Then Exit Sub

            Dim KunciRM As String = dgvPasien.Rows(BarisKe).Cells(0).Value.ToString()
            Dim NilaiBaru As String = ""

            If dgvPasien.Rows(BarisKe).Cells(KolomKe).Value IsNot Nothing Then
                NilaiBaru = dgvPasien.Rows(BarisKe).Cells(KolomKe).Value.ToString()
            End If

            Dim NamaKolomDB As String = ""
            Select Case KolomKe
                Case 1 : NamaKolomDB = "nama_pasien"
                Case 2 : NamaKolomDB = "jenis_kelamin"
                Case 3 : NamaKolomDB = "no_telepon"
            End Select

            If NamaKolomDB = "" Then Exit Sub

            Call BukaKoneksi()
            Dim query As String = "UPDATE tbl_pasien SET " & NamaKolomDB & " = @nilai WHERE no_rm = @rm"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nilai", NilaiBaru)
            Cmd.Parameters.AddWithValue("@rm", KunciRM)
            Cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
            Call TampilDataPasien("")
        End Try
        Call TutupKoneksi()
    End Sub

    Private Sub btnHapusPasien_Click(sender As Object, e As EventArgs) Handles btnhapuspasien.Click
        If dgvPasien.SelectedRows.Count = 0 And dgvPasien.CurrentRow Is Nothing Then
            MsgBox("Klik dulu baris pasien yang mau dihapus!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim BarisAktif As Integer = dgvPasien.CurrentRow.Index
        Dim NoRM As String = dgvPasien.Rows(BarisAktif).Cells(0).Value.ToString()
        Dim Nama As String = dgvPasien.Rows(BarisAktif).Cells(1).Value.ToString()

        If MsgBox("Yakin HAPUS PERMANEN data pasien: " & Nama & "?" & vbCrLf & "Data riwayat medis juga akan hilang!", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()

                Dim cmd1 As New MySqlCommand("DELETE FROM tbl_janji_temu WHERE no_rm = @rm", Conn)
                cmd1.Parameters.AddWithValue("@rm", NoRM)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("DELETE FROM tbl_pasien WHERE no_rm = @rm", Conn)
                cmd2.Parameters.AddWithValue("@rm", NoRM)
                cmd2.ExecuteNonQuery()

                MsgBox("Data Terhapus.", MsgBoxStyle.Information)
                Call TampilDataPasien("")
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            Finally
                Call TutupKoneksi()
            End Try
        End If
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btneditdata.Click
        MsgBox("Fitur Edit Cepat Aktif!" & vbCrLf & vbCrLf & "Silakan KLIK LANGSUNG pada tabel (Nama/Telepon) untuk mengubah isinya, lalu tekan ENTER untuk menyimpan.", MsgBoxStyle.Information, "Info Edit")
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnriwayat.Click
        MsgBox("Fitur Riwayat Kunjungan akan segera hadir.", MsgBoxStyle.Information)
    End Sub

    Private Sub pnlSearch_Paint(sender As Object, e As PaintEventArgs) Handles pnlSearch.Paint

    End Sub
End Class