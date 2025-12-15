Imports MySql.Data.MySqlClient

Public Class ucDokter

    ' --- VARIABEL GLOBAL ---
    Dim IDDokterLogin As String = "DR001" ' Nanti diganti sesuai login
    Dim NoRegistrasiAktif As String = ""
    Dim NoRMAktif As String = ""

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BersihkanForm()
        Call MuatAntrianPasien()
    End Sub

    ' --- 2. LOGIKA MEMUAT ANTRIAN (Panel Kiri) ---
    Sub MuatAntrianPasien()
        Try
            flpDaftarPasien.Controls.Clear()
            Call BukaKoneksi()

            ' Ambil pasien hari ini yang statusnya Menunggu
            Dim tglSekarang As String = Format(Now, "yyyy-MM-dd")

            ' UPDATE QUERY: Saya tambahkan j.keluhan dan j.poli_tujuan agar datanya siap
            Dim query As String = "SELECT j.no_registrasi, j.no_rm, j.keluhan, j.poli_tujuan, p.nama_pasien, p.jenis_kelamin " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.tanggal_janji = '" & tglSekarang & "' AND j.status = 'Menunggu'"

            Dim cmd As New MySqlCommand(query, Conn)
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read
                ' Buat Tombol Pasien
                Dim btnPasien As New Button
                btnPasien.Tag = rd("no_registrasi").ToString()
                btnPasien.Name = rd("no_rm").ToString()

                ' Tampilkan Nama & Poli di tombol antrian
                Dim Nama As String = rd("nama_pasien").ToString()
                Dim Poli As String = rd("poli_tujuan").ToString()
                btnPasien.Text = Nama & vbCrLf & Poli & " (" & rd("no_rm").ToString() & ")"

                ' Styling Tombol
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

        Catch ex As Exception
            MsgBox("Gagal muat antrian: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 3. SAAT PASIEN DIKLIK (Logic Header & Keluhan) ---
    Private Sub PilihPasien(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        NoRegistrasiAktif = btn.Tag.ToString()
        NoRMAktif = btn.Name.ToString()

        Call TampilkanDetailPasien(NoRegistrasiAktif)

        ' Highlight Tombol Biar Kelihatan Terpilih
        For Each ctrl As Control In flpDaftarPasien.Controls
            If TypeOf ctrl Is Button Then ctrl.BackColor = Color.White
        Next
        btn.BackColor = Color.LightBlue
    End Sub

    Sub TampilkanDetailPasien(NoReg As String)
        Try
            Call BukaKoneksi()

            ' UPDATE QUERY: Ambil poli_tujuan dan keluhan untuk ditampilkan detail
            Dim query As String = "SELECT j.keluhan, j.poli_tujuan, p.nama_pasien, p.jenis_kelamin, p.tanggal_lahir, p.alamat " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.no_registrasi = @reg"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoReg)
            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                ' 1. Tampilkan Nama Besar
                lblNamaPasien.Text = Rd("nama_pasien").ToString()

                ' 2. Hitung Umur
                Dim TglLahir As Date = CDate(Rd("tanggal_lahir"))
                Dim Umur As Integer = Now.Year - TglLahir.Year

                ' 3. Tampilkan Header Lengkap (JK | Umur | RM | Poli) -> SESUAI REQUEST
                Dim InfoLengkap As String = Rd("jenis_kelamin").ToString() & " | " &
                                            Umur & " Thn | " &
                                            "RM: " & NoRMAktif & " | " &
                                            Rd("poli_tujuan").ToString() ' <--- Poli muncul disini

                lblDetailPasien.Text = InfoLengkap

                ' 4. Isi Kotak Keluhan (Pastikan kolom 'keluhan' di database ada isinya)
                txtKeluhanawal.Text = Rd("keluhan").ToString()

                btnSimpanperiksa.Enabled = True
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Error ambil detail: " & ex.Message)
        End Try
    End Sub

    ' --- 4. TOMBOL SIMPAN (Simpan SOAP & Selesaikan) ---
    Private Sub btnSimpanPeriksa_Click(sender As Object, e As EventArgs) Handles btnSimpanperiksa.Click
        ' A. Validasi
        If NoRegistrasiAktif = "" Then
            MsgBox("Pilih pasien dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtDiagnosa.Text = "" Or txtTindakan.Text = "" Then
            MsgBox("Diagnosa dan Tindakan/Resep wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Simpan rekam medis dan selesaikan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            ' B. Simpan ke Database
            Dim QuerySimpan As String = "INSERT INTO tbl_rekam_medis (no_registrasi, no_rm, id_dokter, tgl_periksa, keluhan_subjektif, diagnosa, tindakan, alergi_obat, resep_obat) " &
                                        "VALUES (@reg, @rm, @dr, @tgl, @s, @a, @p, @alergi, @resep)"

            Cmd = New MySqlCommand(QuerySimpan, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.Parameters.AddWithValue("@rm", NoRMAktif)
            Cmd.Parameters.AddWithValue("@dr", IDDokterLogin)
            Cmd.Parameters.AddWithValue("@tgl", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            ' SOAP Data
            Cmd.Parameters.AddWithValue("@s", txtSubjective.Text)
            Cmd.Parameters.AddWithValue("@a", txtDiagnosa.Text)

            ' Tindakan & Resep (Diambil dari kotak yang sama)
            Cmd.Parameters.AddWithValue("@p", txtTindakan.Text)     ' Masuk ke kolom tindakan
            Cmd.Parameters.AddWithValue("@resep", txtTindakan.Text) ' Masuk ke kolom resep juga

            Cmd.Parameters.AddWithValue("@alergi", txtAlergi.Text)

            Cmd.ExecuteNonQuery()

            ' C. Update Status Antrian jadi Selesai
            Dim QueryUpdate As String = "UPDATE tbl_janji_temu SET status = 'Selesai' WHERE no_registrasi = @reg"
            Cmd = New MySqlCommand(QueryUpdate, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.ExecuteNonQuery()

            MsgBox("Pemeriksaan Selesai.", MsgBoxStyle.Information)

            Call BersihkanForm()
            Call MuatAntrianPasien()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 5. BERSIHKAN FORM ---
    Sub BersihkanForm()
        lblNamaPasien.Text = "Pilih Pasien..."
        lblDetailPasien.Text = "- | - | -"
        txtKeluhanawal.Clear()
        txtSubjective.Clear()
        txtObjective.Clear()
        txtDiagnosa.Clear()
        txtTindakan.Clear()
        txtAlergi.Clear()

        NoRegistrasiAktif = ""
        NoRMAktif = ""
        btnSimpanperiksa.Enabled = False
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        If NoRMAktif = "" Then
            MsgBox("Pilih pasien dulu.")
            Exit Sub
        End If
        ' Nanti arahkan ke form riwayat atau tampilkan popup riwayat
        MsgBox("Fitur Riwayat untuk Pasien: " & NoRMAktif)
    End Sub

    ' --- 6. FITUR F1 CARI OBAT ---
    Private Sub txtTindakan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTindakan.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim FormCari As New frmCariObat
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

    Private Sub flpKontenKanan_Paint(sender As Object, e As PaintEventArgs) Handles flpKontenKanan.Paint
    End Sub

End Class