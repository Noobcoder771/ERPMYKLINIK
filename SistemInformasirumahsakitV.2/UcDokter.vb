Imports MySql.Data.MySqlClient

Public Class ucDokter

    ' --- VARIABEL GLOBAL ---
    Dim IDDokterLogin As String = "" ' Dikosongkan dulu, nanti diisi otomatis
    Dim NoRegistrasiAktif As String = ""
    Dim NoRMAktif As String = ""

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' CARI TAHU SIAPA DOKTER YANG LOGIN
        Call CariIDDokter()

        If IDDokterLogin = "" Then
            MsgBox("Error: Akun Anda tidak terdaftar sebagai Dokter di database!", MsgBoxStyle.Critical)
            ' Opsional: Tutup form jika id tidak ketemu
            Exit Sub
        End If

        Call BersihkanForm()
        Call MuatAntrianPasien()
    End Sub

    ' --- FUNGSI BARU: MENCARI ID DOKTER BERDASARKAN NAMA LOGIN ---
    Sub CariIDDokter()
        Try
            Call BukaKoneksi()
            ' Kita cari ID Dokter di tabel tbl_dokter yang namanya sama dengan User Login
            ' Module1.UserName didapat dari Form Login
            Dim query As String = "SELECT id_dokter FROM tbl_dokter WHERE nama_dokter = @nama"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", ModulKoneksi.UserName)

            Dim Hasil = Cmd.ExecuteScalar() ' Ambil satu data saja

            If Hasil IsNot Nothing Then
                IDDokterLogin = Hasil.ToString()
                ' Debug (Opsional): MsgBox("Login sebagai: " & IDDokterLogin)
            End If

        Catch ex As Exception
            MsgBox("Gagal Validasi Dokter: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub



    ' --- 2. LOGIKA MEMUAT ANTRIAN (SUDAH DIFILTER) ---
    Sub MuatAntrianPasien()
        Try
            flpDaftarPasien.Controls.Clear()
            Call BukaKoneksi()

            Dim tglSekarang As String = Format(Now, "yyyy-MM-dd")

            ' === PERUBAHAN PENTING DI SINI (WHERE) ===
            ' Tambahkan: AND j.id_dokter = @iddokter
            ' Agar yang muncul HANYA pasien milik dokter yang sedang login

            Dim query As String = "SELECT j.no_registrasi, j.no_rm, j.keluhan, j.poli_tujuan, p.nama_pasien, p.jenis_kelamin " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.tanggal_janji = '" & tglSekarang & "' " &
                                  "AND j.status = 'Menunggu' " &
                                  "AND j.id_dokter = @iddokter" ' <--- INI KUNCINYA

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@iddokter", IDDokterLogin) ' Masukkan ID Dokter yg login

            Dim rd As MySqlDataReader = Cmd.ExecuteReader

            Dim AdaPasien As Boolean = False

            While rd.Read
                AdaPasien = True
                ' Buat Tombol Pasien
                Dim btnPasien As New Button
                btnPasien.Tag = rd("no_registrasi").ToString()
                btnPasien.Name = rd("no_rm").ToString()

                Dim Nama As String = rd("nama_pasien").ToString()
                Dim Poli As String = rd("poli_tujuan").ToString()
                btnPasien.Text = Nama & vbCrLf & Poli & " (" & rd("no_rm").ToString() & ")"

                ' Styling
                btnPasien.Width = flpDaftarPasien.Width - 25
                btnPasien.Height = 70
                btnPasien.BackColor = Color.White
                btnPasien.FlatStyle = FlatStyle.Flat
                btnPasien.TextAlign = ContentAlignment.MiddleLeft
                btnPasien.Padding = New Padding(10, 0, 0, 0)
                btnPasien.Cursor = Cursors.Hand
                btnPasien.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                AddHandler btnPasien.Click, AddressOf PilihPasien
                flpDaftarPasien.Controls.Add(btnPasien)
            End While
            rd.Close()

            If AdaPasien = False Then
                ' Opsional: Tampilkan label jika antrian kosong
                Dim lblKosong As New Label
                lblKosong.Text = "Tidak ada antrian pasien untuk Anda saat ini."
                lblKosong.AutoSize = True
                lblKosong.ForeColor = Color.Gray
                lblKosong.Padding = New Padding(10)
                flpDaftarPasien.Controls.Add(lblKosong)
            End If

        Catch ex As Exception
            MsgBox("Gagal muat antrian: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 3. SAAT PASIEN DIKLIK ---
    Private Sub PilihPasien(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        NoRegistrasiAktif = btn.Tag.ToString()
        NoRMAktif = btn.Name.ToString()

        ' --- TAMBAHAN PENTING ---
        ' Simpan RM ke global agar bisa dibaca di menu Rekam Medis
        ModulKoneksi.NoRMPasienTerpilih = NoRMAktif
        ' ------------------------

        Call TampilkanDetailPasien(NoRegistrasiAktif)

        ' Highlight Tombol
        For Each ctrl As Control In flpDaftarPasien.Controls
            If TypeOf ctrl Is Button Then ctrl.BackColor = Color.White
        Next
        btn.BackColor = Color.LightBlue
    End Sub

    Sub TampilkanDetailPasien(NoReg As String)
        Try
            Call BukaKoneksi()

            Dim query As String = "SELECT j.keluhan, j.poli_tujuan, p.nama_pasien, p.jenis_kelamin, p.tanggal_lahir " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.no_registrasi = @reg"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoReg)
            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                lblNamaPasien.Text = Rd("nama_pasien").ToString()

                Dim JK As String = Rd("jenis_kelamin").ToString()
                Dim TglLahir As Date = CDate(Rd("tanggal_lahir"))
                Dim Umur As Integer = Now.Year - TglLahir.Year

                lblDetailPasien.Text = JK & " | " & Umur & " Thn | RM: " & NoRMAktif & " | " & Rd("poli_tujuan").ToString()
                txtKeluhanawal.Text = Rd("keluhan").ToString()


                btnSimpanperiksa.Enabled = True
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Error ambil detail: " & ex.Message)
        End Try
    End Sub

    ' --- 4. TOMBOL SIMPAN ---
    Private Sub btnSimpanPeriksa_Click(sender As Object, e As EventArgs) Handles btnSimpanperiksa.Click
        If NoRegistrasiAktif = "" Then
            MsgBox("Pilih pasien dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtDiagnosa.Text = "" Or txtTindakan.Text = "" Then
            MsgBox("Diagnosa dan Tindakan wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Simpan rekam medis?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            Dim QuerySimpan As String = "INSERT INTO tbl_rekam_medis (no_registrasi, no_rm, id_dokter, tgl_periksa, keluhan_subjektif, diagnosa, tindakan, alergi_obat, resep_obat) " &
                                        "VALUES (@reg, @rm, @dr, @tgl, @s, @a, @p, @alergi, @resep)"

            Cmd = New MySqlCommand(QuerySimpan, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.Parameters.AddWithValue("@rm", NoRMAktif)
            Cmd.Parameters.AddWithValue("@dr", IDDokterLogin) ' Menggunakan ID Dokter yg Otomatis tadi
            Cmd.Parameters.AddWithValue("@tgl", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@s", txtSubjective.Text)
            Cmd.Parameters.AddWithValue("@a", txtDiagnosa.Text)
            Cmd.Parameters.AddWithValue("@p", txtTindakan.Text)
            Cmd.Parameters.AddWithValue("@resep", txtTindakan.Text)
            Cmd.Parameters.AddWithValue("@alergi", txtAlergi.Text)
            Cmd.ExecuteNonQuery()

            Dim QueryUpdate As String = "UPDATE tbl_janji_temu SET status = 'Selesai' WHERE no_registrasi = @reg"
            Cmd = New MySqlCommand(QueryUpdate, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.ExecuteNonQuery()

            MsgBox("Selesai.", MsgBoxStyle.Information)

            Call BersihkanForm()
            Call MuatAntrianPasien()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Sub BersihkanForm()
        lblNamaPasien.Text = "Pilih Pasien..."
        lblDetailPasien.Text = "- | - | -"
        txtKeluhanawal.Clear()
        txtSubjective.Clear()
        txtDiagnosa.Clear()
        txtTindakan.Clear()
        txtAlergi.Clear()
        NoRegistrasiAktif = ""
        NoRMAktif = ""
        btnSimpanperiksa.Enabled = False
    End Sub

    ' Fitur F1 dan lainnya tetap sama...
    Private Sub txtTindakan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTindakan.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim FormCari As New pilihobatkasir
            If FormCari.ShowDialog() = DialogResult.OK Then
                Dim ObatDipilih As String = FormCari.HasilObat
                Dim IndexAsli As Integer = txtTindakan.SelectionStart
                txtTindakan.Text = txtTindakan.Text.Insert(IndexAsli, ObatDipilih)
                txtTindakan.SelectionStart = IndexAsli + ObatDipilih.Length
                txtTindakan.Focus()
            End If
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub txtTindakan_TextChanged(sender As Object, e As EventArgs) Handles txtTindakan.TextChanged

    End Sub
End Class