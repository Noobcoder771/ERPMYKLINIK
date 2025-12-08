Imports MySql.Data.MySqlClient

Public Class ucjanjitemu

    ' Variabel Global untuk menyimpan No RM Pasien yang ditemukan
    Dim PasienTerpilih As String = ""

    ' --- 1. SAAT FORM DIMUAT (LOAD) ---
    Private Sub ucjanjitemu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setting Placeholder Pencarian
        txtCariRM.Text = "Masukan No. RM"
        txtCariRM.ForeColor = Color.Gray

        ' Sembunyikan panel hasil pencarian di awal
        pnlHasil.Visible = False

        ' Isi Data Poli ke ComboBox agar tidak kosong
        Call IsiComboPoli()

        ' Set tanggal minimal hari ini (Gaboleh pilih kemarin)
        dtpjanji.MinDate = Now
    End Sub

    ' --- 2. SUB UNTUK MENGISI DROPDOWN POLI ---
    Sub IsiComboPoli()
        Try
            Call BukaKoneksi()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbl_poli ORDER BY nama_poli", Conn)
            Dim dt As New DataTable
            da.Fill(dt)

            cmbPoli.DataSource = dt
            cmbPoli.DisplayMember = "nama_poli"
            cmbPoli.ValueMember = "id_poli"
            cmbPoli.SelectedIndex = -1 ' Kosongkan pilihan awal
        Catch ex As Exception
            MsgBox("Gagal Load Poli: " & ex.Message)
        End Try
    End Sub

    ' --- 3. TOMBOL CARI PASIEN (MUNCULKAN PANEL) ---
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ' Validasi Input
        If txtCariRM.Text = "" Or txtCariRM.Text = "Masukan No. RM" Then
            MsgBox("Mohon isi No. RM atau Nama Pasien!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()

            ' Query Cari Pasien (Berdasarkan RM atau Nama)
            Dim query As String = "SELECT * FROM tbl_pasien WHERE no_rm = @cari OR nama_pasien LIKE @nama"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@cari", txtCariRM.Text)
            Cmd.Parameters.AddWithValue("@nama", "%" & txtCariRM.Text & "%")

            Rd = Cmd.ExecuteReader

            If Rd.Read() Then
                ' --- PASIEN DITEMUKAN ---

                ' 1. Simpan No RM ke Variabel Global
                PasienTerpilih = Rd("no_rm").ToString()

                ' 2. Tampilkan Panel Abu-abu (pnlHasil)
                pnlHasil.Visible = True

                ' 3. Isi Label di dalam Panel
                ' Pastikan kamu punya label: lblNamaPasien & lblDetailPasien di dalam pnlHasil
                lblNamaPasien.Text = Rd("nama_pasien").ToString()

                ' Tampilkan detail lengkap
                lblDetailPasien.Text = "No. RM: " & PasienTerpilih & vbCrLf &
                                       "JK: " & Rd("jenis_kelamin").ToString() & vbCrLf &
                                       "Alamat: " & Rd("alamat").ToString()

                ' Ubah warna nama biar jelas
                lblNamaPasien.ForeColor = Color.DarkBlue

            Else
                ' --- TIDAK DITEMUKAN ---
                MsgBox("Data Pasien tidak ditemukan.", MsgBoxStyle.Information)
                PasienTerpilih = ""
                pnlHasil.Visible = False
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Error Cari: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 4. FILTER DOKTER OTOMATIS (LOGIKA PINTAR) ---
    Sub FilterDokterOtomatis()
        ' Syarat: Poli harus dipilih dulu
        If cmbPoli.SelectedIndex = -1 Then Exit Sub

        Try
            Dim hariIni As String = GetHariIndo(dtpjanji.Value)
            Dim idPoliDipilih As String = cmbPoli.SelectedValue.ToString()

            Call BukaKoneksi()

            ' Query: Ambil Dokter sesuai Poli DAN Harinya
            Dim query As String = "SELECT d.id_dokter, d.nama_dokter, j.jam_mulai, j.jam_selesai " &
                                  "FROM tbl_dokter d " &
                                  "JOIN tbl_jadwal_dokter j ON d.id_dokter = j.id_dokter " &
                                  "WHERE d.id_poli = @poli AND j.hari = @hari"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@poli", idPoliDipilih)
            Cmd.Parameters.AddWithValue("@hari", hariIni)

            Dim da As New MySqlDataAdapter(Cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Buat tampilan cantik: "Dr. Budi | 09:00-12:00"
            dt.Columns.Add("Tampilan", GetType(String))
            For Each row As DataRow In dt.Rows
                row("Tampilan") = row("nama_dokter") & " | " & row("jam_mulai") & "-" & row("jam_selesai")
            Next

            cmbDokter.DataSource = dt
            cmbDokter.DisplayMember = "Tampilan"
            cmbDokter.ValueMember = "id_dokter"

            If dt.Rows.Count = 0 Then
                cmbDokter.DataSource = Nothing
                cmbDokter.Items.Clear()
                cmbDokter.Text = "Tidak ada dokter jadwal " & hariIni
            Else
                cmbDokter.SelectedIndex = -1
            End If

        Catch ex As Exception
            ' Error loading diabaikan saja
        End Try
    End Sub

    ' Trigger saat Poli berubah
    Private Sub cmbPoli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPoli.SelectedIndexChanged
        Call FilterDokterOtomatis()
    End Sub

    ' Trigger saat Tanggal berubah
    Private Sub dtpjanji_ValueChanged(sender As Object, e As EventArgs) Handles dtpjanji.ValueChanged
        Call FilterDokterOtomatis()
    End Sub

    ' --- 5. TOMBOL BUAT JANJI (SIMPAN DATA) ---
    ' Ini adalah kode yang sudah diperbaiki bagian KELUHAN-nya
    Private Sub btnBuatJanji_Click(sender As Object, e As EventArgs) Handles btnBuatJanji.Click
        ' Validasi Input
        If PasienTerpilih = "" Then
            MsgBox("Cari Pasien Dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cmbDokter.SelectedIndex = -1 Then
            MsgBox("Pilih Dokter dan Jadwal!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()

            ' A. Generate No Registrasi Baru
            Dim NoRegBaru As String = GenerateNoRegistrasi()

            ' B. Simpan ke Database
            Dim QuerySimpan As String = "INSERT INTO tbl_janji_temu (no_registrasi, no_rm, id_dokter, id_poli, tanggal_janji, keluhan, tanggal_dibuat, status, no_antrian) VALUES (@reg, @rm, @dr, @poli, @tgl, @keluhan, @dibuat, 'Menunggu', 0)"

            Cmd = New MySqlCommand(QuerySimpan, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegBaru)
            Cmd.Parameters.AddWithValue("@rm", PasienTerpilih)
            Cmd.Parameters.AddWithValue("@dr", cmbDokter.SelectedValue)
            Cmd.Parameters.AddWithValue("@poli", cmbPoli.SelectedValue)
            Cmd.Parameters.AddWithValue("@tgl", dtpjanji.Value.ToString("yyyy-MM-dd"))

            ' --- PERBAIKAN DI SINI (LOGIKA KELUHAN) ---
            ' Pastikan kamu punya TextBox bernama txtKeluhan di desain
            If txtKeluhan.Text = "" Then
                Cmd.Parameters.AddWithValue("@keluhan", "-")
            Else
                Cmd.Parameters.AddWithValue("@keluhan", txtKeluhan.Text)
            End If
            ' -------------------------------------------

            Cmd.Parameters.AddWithValue("@dibuat", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            Cmd.ExecuteNonQuery()

            ' C. Sukses
            MsgBox("Pendaftaran Berhasil!" & vbCrLf & "No Registrasi: " & NoRegBaru, MsgBoxStyle.Information)

            ' Reset Form agar siap dipakai lagi
            txtCariRM.Text = "Masukan No. RM"
            txtCariRM.ForeColor = Color.Gray
            pnlHasil.Visible = False
            PasienTerpilih = ""
            txtKeluhan.Clear() ' Bersihkan keluhan
            cmbPoli.SelectedIndex = -1
            cmbDokter.DataSource = Nothing

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- FUNGSI PENDUKUNG ---

    ' Fungsi 1: Generate Nomor Registrasi (Unik)
    Function GenerateNoRegistrasi() As String
        Dim noReg As String = ""
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim tgl As String = Format(Now, "yyyyMMdd")
            Dim prefix As String = "REG" & tgl

            Dim query As String = "SELECT no_registrasi FROM tbl_janji_temu WHERE no_registrasi LIKE '" & prefix & "%' ORDER BY no_registrasi DESC LIMIT 1"
            Dim cmdReg As New MySqlCommand(query, Conn)
            Dim rdReg As MySqlDataReader = cmdReg.ExecuteReader()

            If rdReg.Read Then
                Dim lastNo As String = rdReg("no_registrasi").ToString()
                Dim urutan As Integer = Val(Microsoft.VisualBasic.Right(lastNo, 3)) + 1
                noReg = prefix & Format(urutan, "000")
            Else
                noReg = prefix & "001"
            End If
            rdReg.Close()
        Catch ex As Exception
            MsgBox("Error REG: " & ex.Message)
        End Try
        Return noReg
    End Function

    ' Fungsi 2: Terjemahkan Hari (Inggris ke Indo)
    Function GetHariIndo(tanggal As DateTime) As String
        Select Case tanggal.DayOfWeek
            Case DayOfWeek.Sunday : Return "Minggu"
            Case DayOfWeek.Monday : Return "Senin"
            Case DayOfWeek.Tuesday : Return "Selasa"
            Case DayOfWeek.Wednesday : Return "Rabu"
            Case DayOfWeek.Thursday : Return "Kamis"
            Case DayOfWeek.Friday : Return "Jumat"
            Case DayOfWeek.Saturday : Return "Sabtu"
            Case Else : Return ""
        End Select
    End Function

    ' --- PLACEHOLDER TEXTBOX PENCARIAN ---
    Private Sub txtCariRM_Enter(sender As Object, e As EventArgs) Handles txtCariRM.Enter
        If txtCariRM.Text = "Masukan No. RM" Then
            txtCariRM.Text = ""
            txtCariRM.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCariRM_Leave(sender As Object, e As EventArgs) Handles txtCariRM.Leave
        If txtCariRM.Text = "" Then
            txtCariRM.Text = "Masukan No. RM"
            txtCariRM.ForeColor = Color.Gray
        End If
    End Sub

End Class