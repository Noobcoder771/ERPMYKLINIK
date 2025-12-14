Imports MySql.Data.MySqlClient

Public Class ucFarmasi

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucFarmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AturGrid() ' <--- PENTING: Mengatur kolom agar bisa diedit
        Call TampilDataObat("")
        Call BersihkanForm()
    End Sub

    ' --- 2. PENGATURAN GRID (AGAR BISA EDIT LANGSUNG) ---
    Sub AturGrid()
        dgvObat.AutoGenerateColumns = False

        ' Pastikan kamu sudah membuat 5 Kolom di Desain (Klik Kanan DGV -> Edit Columns)
        ' Urutan Indeks Kolom harus sesuai:

        ' Kolom 0: No. Kode Obat
        dgvObat.Columns(0).DataPropertyName = "kode_obat"

        ' Kolom 1: Nama Obat
        dgvObat.Columns(1).DataPropertyName = "nama_obat"

        ' Kolom 2: Satuan (Jenis)
        dgvObat.Columns(2).DataPropertyName = "jenis_obat"

        ' Kolom 3: Stok (Angka)
        dgvObat.Columns(3).DataPropertyName = "stok"
        dgvObat.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Kolom 4: Harga Jual (Rupiah)
        dgvObat.Columns(4).DataPropertyName = "harga_satuan"
        dgvObat.Columns(4).DefaultCellStyle.Format = "N0" ' Format angka ribuan (tanpa Rp biar mudah diedit)
        dgvObat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ' PENTING: Kita butuh ID Obat tapi disembunyikan
        ' Tambahkan kolom baru lewat kodingan untuk menyimpan ID (Primary Key)
        If dgvObat.Columns.Contains("id_obat") = False Then
            Dim colID As New DataGridViewTextBoxColumn
            colID.Name = "id_obat"
            colID.DataPropertyName = "id_obat"
            colID.Visible = False ' Sembunyikan
            dgvObat.Columns.Add(colID)
        End If
    End Sub

    ' --- 3. TAMPILKAN DATA ---
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

    ' --- 4. LOGIKA EDIT LANGSUNG DI TABEL (CORE FITUR) ---
    Private Sub dgvObat_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObat.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Try
            ' A. Ambil ID Obat (Kunci Utama) dari kolom tersembunyi
            ' Kita cari kolom bernama "id_obat"
            If dgvObat.Rows(e.RowIndex).Cells("id_obat").Value Is Nothing Then Exit Sub
            Dim IDObat As String = dgvObat.Rows(e.RowIndex).Cells("id_obat").Value.ToString()

            ' B. Tentukan Kolom Mana yang Diedit
            Dim KolomKe As Integer = e.ColumnIndex
            Dim NamaKolomDB As String = ""
            Dim NilaiBaru As String = ""

            If dgvObat.Rows(e.RowIndex).Cells(KolomKe).Value IsNot Nothing Then
                NilaiBaru = dgvObat.Rows(e.RowIndex).Cells(KolomKe).Value.ToString()
            End If

            ' Mapping Indeks Kolom ke Nama Kolom Database
            ' Sesuaikan urutan ini dengan desain tabel kamu!
            Select Case KolomKe
                Case 0 : NamaKolomDB = "kode_obat"
                Case 1 : NamaKolomDB = "nama_obat"
                Case 2 : NamaKolomDB = "jenis_obat"
                Case 3 : NamaKolomDB = "stok"
                Case 4 : NamaKolomDB = "harga_satuan"
            End Select

            If NamaKolomDB = "" Then Exit Sub

            ' C. Update ke Database
            Call BukaKoneksi()
            Dim query As String = "UPDATE tbl_obat SET " & NamaKolomDB & " = @nilai WHERE id_obat = @id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nilai", NilaiBaru)
            Cmd.Parameters.AddWithValue("@id", IDObat)
            Cmd.ExecuteNonQuery()

            ' Debug.WriteLine("Stok/Harga terupdate otomatis")

        Catch ex As Exception
            MsgBox("Gagal Update Otomatis: " & ex.Message)
            Call TampilDataObat("") ' Refresh jika error
        End Try

        Call TutupKoneksi()
    End Sub

    ' --- 5. TOMBOL TAMBAH BARU (Panel Kiri) ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi
        If txtKode.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Lengkapi data obat baru!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()
            ' Mode Tambah Baru (INSERT Only)
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

    ' --- 6. TOMBOL HAPUS (Panel Kiri) ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Cek baris yang dipilih di tabel
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

    ' --- 7. TOMBOL CARI ---
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call TampilDataObat(txtSearch.Text)
    End Sub

    ' --- 8. RESET FORM ---
    Sub BersihkanForm()
        txtKode.Clear()
        txtNama.Clear()
        cbSatuan.SelectedIndex = -1
        nudStok.Value = 0
        txtHarga.Clear()
    End Sub

    ' (Opsional) Biar TextBox Harga hanya bisa diisi angka
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tlpMain_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tlpMain_Paint_1(sender As Object, e As PaintEventArgs) Handles tlpMain.Paint

    End Sub
End Class