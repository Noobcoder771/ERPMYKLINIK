Imports MySql.Data.MySqlClient

Public Class ucDokter

    ' --- VARIABEL GLOBAL UNTUK MENYIMPAN SESI ---
    ' Nanti ID Dokter ini diambil dari Login. Sementara kita set default dulu.
    Dim IDDokterLogin As String = "DR001"

    ' Variabel Pasien yang sedang dipilih
    Dim NoRegistrasiAktif As String = ""
    Dim NoRMAktif As String = ""

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup tampilan awal
        Call BersihkanForm()

        ' Load antrian pasien hari ini
        Call MuatAntrianPasien()

        ' (Opsional) Percantik tampilan via kode jika perlu
        ' Call SetupTampilanModern() 
    End Sub

    ' --- 2. LOGIKA MEMUAT ANTRIAN (Panel Kiri) ---
    Sub MuatAntrianPasien()
        Try
            flpDaftarPasien.Controls.Clear() ' Bersihkan daftar lama (Pastikan nama FlowLayoutPanel-nya flpDaftarPasien)

            Call BukaKoneksi()

            ' Query: Ambil pasien yang statusnya 'Menunggu' HARI INI
            ' Kita JOIN dengan tbl_pasien untuk dapat namanya
            Dim tglSekarang As String = Format(Now, "yyyy-MM-dd")

            Dim query As String = "SELECT j.no_registrasi, j.no_rm, j.keluhan, p.nama_pasien, p.jenis_kelamin " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.tanggal_janji = '" & tglSekarang & "' AND j.status = 'Menunggu'"

            Dim cmd As New MySqlCommand(query, Conn)
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read
                ' --- TEKNIK DYNAMIC CONTROL ---
                ' Kita bikin tombol lewat kodingan (bukan drag-drop)
                Dim btnPasien As New Button

                ' Simpan data penting di dalam tombol (tersembunyi)
                btnPasien.Tag = rd("no_registrasi").ToString()
                btnPasien.Name = rd("no_rm").ToString() ' Simpan RM di properti Name

                ' Desain Tombolnya biar mirip Kartu
                btnPasien.Text = rd("nama_pasien").ToString() & vbCrLf &
                                 "RM: " & rd("no_rm").ToString()

                btnPasien.Width = flpDaftarPasien.Width - 25 ' Agar pas lebarnya
                btnPasien.Height = 70
                btnPasien.BackColor = Color.White
                btnPasien.FlatStyle = FlatStyle.Flat
                btnPasien.FlatAppearance.BorderColor = Color.LightGray
                btnPasien.TextAlign = ContentAlignment.MiddleLeft
                btnPasien.Padding = New Padding(10, 0, 0, 0)
                btnPasien.Cursor = Cursors.Hand
                btnPasien.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                ' TAMBAHKAN EVENT KLIK (PENTING!)
                ' Saat tombol ini diklik, dia akan memanggil fungsi 'PilihPasien'
                AddHandler btnPasien.Click, AddressOf PilihPasien

                ' Masukkan tombol ke Panel
                flpDaftarPasien.Controls.Add(btnPasien)
            End While
            rd.Close()

        Catch ex As Exception
            MsgBox("Gagal muat antrian: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 3. SAAT SALAH SATU PASIEN DIKLIK ---
    Private Sub PilihPasien(sender As Object, e As EventArgs)
        ' Ubah tombol sender menjadi objek Button agar bisa dibaca
        Dim btn As Button = CType(sender, Button)

        ' Ambil data dari tombol yang diklik
        NoRegistrasiAktif = btn.Tag.ToString()
        NoRMAktif = btn.Name.ToString()

        ' Tampilkan detail ke Form Tengah
        Call TampilkanDetailPasien(NoRegistrasiAktif)

        ' Ubah warna tombol biar ketahuan mana yang dipilih
        For Each ctrl As Control In flpDaftarPasien.Controls
            If TypeOf ctrl Is Button Then ctrl.BackColor = Color.White ' Reset warna lain
        Next
        btn.BackColor = Color.LightBlue ' Highlight yang dipilih
    End Sub

    Sub TampilkanDetailPasien(NoReg As String)
        Try
            Call BukaKoneksi()
            ' Ambil detail lengkap: Nama, Umur, Keluhan Awal
            Dim query As String = "SELECT j.keluhan, p.nama_pasien, p.jenis_kelamin, p.tanggal_lahir, p.alamat " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "WHERE j.no_registrasi = @reg"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoReg)
            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                ' Isi Header (Pastikan nama label di desain kamu lblNamaPasien & lblDetailPasien)
                lblNamaPasien.Text = Rd("nama_pasien").ToString()

                ' Hitung Umur (Opsional)
                Dim TglLahir As Date = CDate(Rd("tanggal_lahir"))
                Dim Umur As Integer = Now.Year - TglLahir.Year

                lblDetailPasien.Text = Rd("jenis_kelamin").ToString() & " | " & Umur & " Tahun | " & NoRMAktif

                ' Isi Keluhan Awal (ReadOnly)
                txtKeluhanAwal.Text = Rd("keluhan").ToString()

                ' Aktifkan tombol simpan
                btnSimpanPeriksa.Enabled = True
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Error ambil detail: " & ex.Message)
        End Try
    End Sub

    ' --- 4. TOMBOL SIMPAN & SELESAIKAN (Panel Kanan) ---
    Private Sub btnSimpanPeriksa_Click(sender As Object, e As EventArgs) Handles btnSimpanPeriksa.Click
        ' A. Validasi
        If NoRegistrasiAktif = "" Then
            MsgBox("Pilih pasien dulu dari antrian!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtDiagnosa.Text = "" Or txtTindakan.Text = "" Then
            MsgBox("Diagnosa dan Resep wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Simpan rekam medis dan selesaikan pasien ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            ' B. SIMPAN KE TBL_REKAM_MEDIS
            Dim QuerySimpan As String = "INSERT INTO tbl_rekam_medis (no_registrasi, no_rm, id_dokter, tgl_periksa, keluhan_subjektif, diagnosa, tindakan, alergi_obat, resep_obat) " &
                                        "VALUES (@reg, @rm, @dr, @tgl, @s, @a, @p, @alergi, @resep)"

            Cmd = New MySqlCommand(QuerySimpan, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.Parameters.AddWithValue("@rm", NoRMAktif)
            Cmd.Parameters.AddWithValue("@dr", IDDokterLogin)
            Cmd.Parameters.AddWithValue("@tgl", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            ' SOAP Data
            Cmd.Parameters.AddWithValue("@s", txtSubjective.Text)
            ' Note: Objective bisa digabung ke S atau P jika di database ga ada kolomnya, 
            ' tapi idealnya ada kolom 'pemeriksaan_fisik' di DB. 
            ' Untuk sekarang kita asumsikan kolomnya sesuai DB kamu.

            Cmd.Parameters.AddWithValue("@a", txtDiagnosa.Text)
            Cmd.Parameters.AddWithValue("@p", txtTindakan.Text)

            ' Panel Kanan
            Cmd.Parameters.AddWithValue("@alergi", txtAlergi.Text)
            Cmd.Parameters.AddWithValue("@resep", txtTindakan.Text)

            Cmd.ExecuteNonQuery()

            ' C. UPDATE STATUS ANTRIAN JADI 'SELESAI'
            ' Supaya pasien ini hilang dari daftar antrian
            Dim QueryUpdate As String = "UPDATE tbl_janji_temu SET status = 'Selesai' WHERE no_registrasi = @reg"
            Cmd = New MySqlCommand(QueryUpdate, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegistrasiAktif)
            Cmd.ExecuteNonQuery()

            MsgBox("Pemeriksaan Selesai. Data tersimpan.", MsgBoxStyle.Information)

            ' D. RESET FORM & REFRESH ANTRIAN
            Call BersihkanForm()
            Call MuatAntrianPasien()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 5. BERSIHKAN LAYAR ---
    Sub BersihkanForm()
        lblNamaPasien.Text = "Pilih Pasien..."
        lblDetailPasien.Text = "- | - | -"
        txtKeluhanawal.Clear()

        txtSubjective.Clear()
        txtObjective.Clear()
        txtDiagnosa.Clear()
        txtTindakan.Clear()

        txtAlergi.Clear()
        txtTindakan.Clear()

        NoRegistrasiAktif = ""
        NoRMAktif = ""
        btnSimpanPeriksa.Enabled = False
    End Sub

    ' Tombol Lihat Riwayat (Opsional)
    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        If NoRMAktif = "" Then
            MsgBox("Pilih pasien dulu untuk melihat riwayatnya.")
            Exit Sub
        End If

        MsgBox("Fitur Riwayat untuk Pasien RM: " & NoRMAktif & " akan muncul di sini (Next Project).")
        ' Nanti bisa buka Form baru berisi DataGridView riwayat medis lama
    End Sub

End Class