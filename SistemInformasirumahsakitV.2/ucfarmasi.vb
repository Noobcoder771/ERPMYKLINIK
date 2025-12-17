Imports MySql.Data.MySqlClient

Public Class ucFarmasi

    Private Sub ucFarmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AturGrid() '
        Call TampilDataObat("")
        Call BersihkanForm()
    End Sub


    Sub AturGrid()
        dgvObat.AutoGenerateColumns = False


        dgvObat.Columns(0).DataPropertyName = "kode_obat"

        dgvObat.Columns(1).DataPropertyName = "nama_obat"

        dgvObat.Columns(2).DataPropertyName = "jenis_obat"

        dgvObat.Columns(3).DataPropertyName = "stok"
        dgvObat.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvObat.Columns(4).DataPropertyName = "harga_satuan"
        dgvObat.Columns(4).DefaultCellStyle.Format = "N0"
        dgvObat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If dgvObat.Columns.Contains("id_obat") = False Then
            Dim colID As New DataGridViewTextBoxColumn
            colID.Name = "id_obat"
            colID.DataPropertyName = "id_obat"
            colID.Visible = False
            dgvObat.Columns.Add(colID)
        End If
    End Sub

    Sub TampilDataObat(keyword As String)
        Try
            Call BukaKoneksi()
            Dim query As String = ""

            If keyword = "" Then
                query = "SELECT * FROM tbl_obat ORDER BY nama_obat ASC"
            Else
                query = "SELECT * FROM tbl_obat WHERE nama_obat LIKE '%" & keyword & "%' OR kode_obat LIKE '%" & keyword & "%'"
            End If

            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvObat.DataSource = dt

        Catch ex As Exception
            MsgBox("Gagal Tampil: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvObat_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObat.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Try

            If dgvObat.Rows(e.RowIndex).Cells("id_obat").Value Is Nothing Then Exit Sub
            Dim IDObat As String = dgvObat.Rows(e.RowIndex).Cells("id_obat").Value.ToString()

            Dim KolomKe As Integer = e.ColumnIndex
            Dim NamaKolomDB As String = ""
            Dim NilaiBaru As String = ""

            If dgvObat.Rows(e.RowIndex).Cells(KolomKe).Value IsNot Nothing Then
                NilaiBaru = dgvObat.Rows(e.RowIndex).Cells(KolomKe).Value.ToString()
            End If

            Select Case KolomKe
                Case 0 : NamaKolomDB = "kode_obat"
                Case 1 : NamaKolomDB = "nama_obat"
                Case 2 : NamaKolomDB = "jenis_obat"
                Case 3 : NamaKolomDB = "stok"
                Case 4 : NamaKolomDB = "harga_satuan"
            End Select

            If NamaKolomDB = "" Then Exit Sub

            Call BukaKoneksi()
            Dim query As String = "UPDATE tbl_obat SET " & NamaKolomDB & " = @nilai WHERE id_obat = @id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nilai", NilaiBaru)
            Cmd.Parameters.AddWithValue("@id", IDObat)
            Cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Gagal Update Otomatis: " & ex.Message)
            Call TampilDataObat("")
        End Try

        Call TutupKoneksi()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Lengkapi data obat baru!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()
            Dim query As String = "INSERT INTO tbl_obat (kode_obat, nama_obat, jenis_obat, stok, harga_satuan) VALUES (@kode, @nama, @jenis, @stok, @harga)"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@kode", txtKode.Text)
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            Cmd.Parameters.AddWithValue("@jenis", cbSatuan.Text)
            Cmd.Parameters.AddWithValue("@stok", nudStok.Value)
            Cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            Cmd.ExecuteNonQuery()

            MsgBox("Obat Baru Ditambahkan!")
            Call BersihkanForm()
            Call TampilDataObat("")

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgvObat.CurrentRow Is Nothing Then
            MsgBox("Pilih obat di tabel yang mau dihapus.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim Nama As String = dgvObat.CurrentRow.Cells(1).Value.ToString()
        Dim ID As String = dgvObat.CurrentRow.Cells("id_obat").Value.ToString()

        If MsgBox("Hapus permanen obat: " & Nama & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()
                Dim cmd As New MySqlCommand("DELETE FROM tbl_obat WHERE id_obat='" & ID & "'", Conn)
                cmd.ExecuteNonQuery()

                Call TampilDataObat("")
                MsgBox("Terhapus.")
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call TampilDataObat(txtSearch.Text)
    End Sub

    Sub BersihkanForm()
        txtKode.Clear()
        txtNama.Clear()
        cbSatuan.SelectedIndex = -1
        nudStok.Value = 0
        txtHarga.Clear()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tlpMain_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tlpMain_Paint_1(sender As Object, e As PaintEventArgs) Handles tlpMain.Paint

    End Sub

    Private Sub PnlContent_Paint(sender As Object, e As PaintEventArgs) Handles PnlContent.Paint

    End Sub
End Class