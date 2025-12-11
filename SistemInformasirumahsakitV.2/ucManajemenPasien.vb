Imports MySql.Data.MySqlClient

Public Class ucManajemenPasien

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucManajemenPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AturGrid() ' <-- INI KUNCI AGAR TABEL RAPI
        Call TampilDataPasien("")
    End Sub

    ' --- 2. PENGATURAN GRID (ANTI NUBRUK) ---
    Sub AturGrid()
        ' Matikan pembuatan kolom otomatis (Wajib!)
        dgvPasien.AutoGenerateColumns = False

        ' MAPPING: Sambungkan Kolom Desainmu dengan Nama Kolom Database
        ' Pastikan urutan indeks (0, 1, 2...) sesuai urutan kolom di desainmu

        ' Kolom 0: No RM
        dgvPasien.Columns(0).DataPropertyName = "no_rm"
        dgvPasien.Columns(0).ReadOnly = True ' No RM gaboleh diedit
        dgvPasien.Columns(0).DefaultCellStyle.BackColor = Color.LightGray

        ' Kolom 1: Nama Lengkap
        dgvPasien.Columns(1).DataPropertyName = "nama_pasien"

        ' Kolom 2: Jenis Kelamin
        dgvPasien.Columns(2).DataPropertyName = "jenis_kelamin"

        ' Kolom 3: No Telepon
        dgvPasien.Columns(3).DataPropertyName = "no_telepon"

        ' Kolom 4: Tgl Registrasi
        dgvPasien.Columns(4).DataPropertyName = "tgl_registrasi"
        dgvPasien.Columns(4).ReadOnly = True ' Tanggal gaboleh diedit sembarangan
    End Sub

    ' --- 3. TAMPILKAN DATA ---
    Sub TampilDataPasien(keyword As String)
        Try
            Call BukaKoneksi()
            Dim query As String

            If keyword = "" Then
                ' Tampilkan 50 data terbaru
                query = "SELECT no_rm, nama_pasien, jenis_kelamin, no_telepon, tgl_registrasi FROM tbl_pasien ORDER BY tgl_registrasi DESC LIMIT 50"
            Else
                ' Mode Pencarian
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

    ' --- 4. TOMBOL CARI ---
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ' Pastikan nama tombol carimu btnCari
        Call TampilDataPasien(txtCari.Text)
    End Sub

    ' --- 5. SIMPAN OTOMATIS (EDIT ALA EXCEL) ---
    ' Event ini berjalan saat kamu selesai mengedit sel dan tekan Enter
    Private Sub dgvPasien_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPasien.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim BarisKe As Integer = e.RowIndex
            Dim KolomKe As Integer = e.ColumnIndex

            ' Safety Check
            If dgvPasien.Rows(BarisKe).Cells(0).Value Is Nothing Then Exit Sub

            Dim KunciRM As String = dgvPasien.Rows(BarisKe).Cells(0).Value.ToString()
            Dim NilaiBaru As String = ""

            If dgvPasien.Rows(BarisKe).Cells(KolomKe).Value IsNot Nothing Then
                NilaiBaru = dgvPasien.Rows(BarisKe).Cells(KolomKe).Value.ToString()
            End If

            ' Tentukan kolom mana yang diedit berdasarkan indeksnya
            Dim NamaKolomDB As String = ""
            Select Case KolomKe
                Case 1 : NamaKolomDB = "nama_pasien"
                Case 2 : NamaKolomDB = "jenis_kelamin"
                Case 3 : NamaKolomDB = "no_telepon"
            End Select

            If NamaKolomDB = "" Then Exit Sub ' Kolom lain (RM/Tgl) diabaikan

            ' Update Database
            Call BukaKoneksi()
            Dim query As String = "UPDATE tbl_pasien SET " & NamaKolomDB & " = @nilai WHERE no_rm = @rm"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nilai", NilaiBaru)
            Cmd.Parameters.AddWithValue("@rm", KunciRM)
            Cmd.ExecuteNonQuery()

            ' Feedback (Opsional)
            ' MsgBox("Data tersimpan otomatis.") 

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
            Call TampilDataPasien("") ' Refresh jika error
        End Try
        Call TutupKoneksi()
    End Sub

    ' --- 6. TOMBOL HAPUS PASIEN ---
    Private Sub btnHapusPasien_Click(sender As Object, e As EventArgs) Handles btnHapusPasien.Click
        ' Cek apakah ada baris yang dipilih
        If dgvPasien.SelectedRows.Count = 0 And dgvPasien.CurrentRow Is Nothing Then
            MsgBox("Klik dulu baris pasien yang mau dihapus!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Ambil No RM dari baris yang aktif
        Dim BarisAktif As Integer = dgvPasien.CurrentRow.Index
        Dim NoRM As String = dgvPasien.Rows(BarisAktif).Cells(0).Value.ToString()
        Dim Nama As String = dgvPasien.Rows(BarisAktif).Cells(1).Value.ToString()

        If MsgBox("Yakin HAPUS PERMANEN data pasien: " & Nama & "?" & vbCrLf & "Data riwayat medis juga akan hilang!", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()

                ' Hapus data anak dulu (Janji Temu)
                Dim cmd1 As New MySqlCommand("DELETE FROM tbl_janji_temu WHERE no_rm = @rm", Conn)
                cmd1.Parameters.AddWithValue("@rm", NoRM)
                cmd1.ExecuteNonQuery()

                ' Hapus data induk (Pasien)
                Dim cmd2 As New MySqlCommand("DELETE FROM tbl_pasien WHERE no_rm = @rm", Conn)
                cmd2.Parameters.AddWithValue("@rm", NoRM)
                cmd2.ExecuteNonQuery()

                MsgBox("Data Terhapus.", MsgBoxStyle.Information)
                Call TampilDataPasien("") ' Refresh Tabel

            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            Finally
                Call TutupKoneksi()
            End Try
        End If
    End Sub

    ' --- 7. TOMBOL EDIT DATA (INFO) ---
    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        MsgBox("Fitur Edit Cepat Aktif!" & vbCrLf & vbCrLf & "Silakan KLIK LANGSUNG pada tabel (Nama/Telepon) untuk mengubah isinya, lalu tekan ENTER untuk menyimpan.", MsgBoxStyle.Information, "Info Edit")
    End Sub

    ' --- 8. TOMBOL RIWAYAT (PLACEHOLDER) ---
    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        MsgBox("Fitur Riwayat Kunjungan akan segera hadir.", MsgBoxStyle.Information)
    End Sub

End Class