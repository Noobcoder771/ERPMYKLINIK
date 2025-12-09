Imports MySql.Data.MySqlClient

Public Class ucManajemenPasien

    Private Sub ucManajemenPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilDataPasien("")

        ' Pastikan kolom No RM tidak bisa diedit (Read Only), sisanya boleh
        If dgvPasien.Columns.Contains("no_rm") Then
            dgvPasien.Columns("no_rm").ReadOnly = True
            dgvPasien.Columns("no_rm").DefaultCellStyle.BackColor = Color.LightGray ' Kasih warna beda
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tlpMain_Paint(sender As Object, e As PaintEventArgs) Handles tlpMain.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlSearch_Paint(sender As Object, e As PaintEventArgs) Handles pnlSearch.Paint

    End Sub

    Private Sub dgvPasien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPasien.CellContentClick
        Try
            ' Ambil data penting dari baris yang diedit
            Dim BarisKe As Integer = e.RowIndex
            Dim KolomKe As Integer = e.ColumnIndex

            ' Ambil No RM sebagai kunci (Primary Key)
            Dim KunciRM As String = dgvPasien.Rows(BarisKe).Cells("no_rm").Value.ToString()

            ' Ambil Nama Kolom yang diedit (Harus sama dengan nama kolom di MySQL!)
            Dim NamaKolom As String = dgvPasien.Columns(KolomKe).Name

            ' Ambil Nilai Baru yang barusan diketik
            Dim NilaiBaru As String = dgvPasien.Rows(BarisKe).Cells(KolomKe).Value.ToString()

            ' --- PROSES UPDATE KE DATABASE ---
            Call BukaKoneksi()

            ' Query Dinamis: Update tabel SET kolom_ini = nilai_baru WHERE no_rm = kunci
            Dim query As String = "UPDATE tbl_pasien SET " & NamaKolom & " = @nilai WHERE no_rm = @rm"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nilai", NilaiBaru)
            Cmd.Parameters.AddWithValue("@rm", KunciRM)

            Cmd.ExecuteNonQuery()

            ' Feedback kecil di pojok form atau console (Opsional)
            ' Debug.WriteLine("Data tersimpan otomatis")

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message & vbCrLf & "Pastikan Nama Kolom Tabel sama dengan Database!")
            ' Kembalikan data lama jika error (Reload)
            Call TampilDataPasien("")
        End Try

        Call TutupKoneksi()
    End Sub
    Sub TampilDataPasien(keyword As String)
        Try
            Call BukaKoneksi()
            Dim query As String

            ' Cek apakah sedang mencari atau menampilkan semua
            If keyword = "" Then
                ' Ambil 50 data terbaru
                query = "SELECT no_rm, nama_pasien, nik, jenis_kelamin, no_telepon, tgl_registrasi FROM tbl_pasien ORDER BY tgl_registrasi DESC LIMIT 50"
            Else
                ' Cari berdasarkan Nama atau RM
                query = "SELECT no_rm, nama_pasien, nik, jenis_kelamin, no_telepon, tgl_registrasi FROM tbl_pasien WHERE no_rm LIKE '%" & keyword & "%' OR nama_pasien LIKE '%" & keyword & "%'"
            End If

            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Masukkan data ke DataGridView
            dgvPasien.DataSource = dt

            ' (Opsional) Rapikan kolom
            dgvPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub
End Class
