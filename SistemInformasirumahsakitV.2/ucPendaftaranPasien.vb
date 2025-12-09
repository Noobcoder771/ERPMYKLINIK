Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ucPendaftaranPasien
    Dim NoRMBaru As String = ""

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsiComboPoli()
        Call PercantikTampilan()

        ' Setting ComboBox Pembayaran (Manual saja lebih cepat)
        cmbBayar.Items.Clear()
        cmbBayar.Items.Add("Umum / Tunai")
        cmbBayar.Items.Add("BPJS Kesehatan")
        cmbBayar.Items.Add("Asuransi Lain")
        cmbBayar.SelectedIndex = 0 ' Default ke Umum

        ' CATATAN: dtpRegistrasi sudah dihapus dari kodingan ini
        ' Tanggal akan kita ambil langsung dari sistem (Now) saat Simpan.
    End Sub

    ' --- 2. ISI COMBOBOX POLI DARI DATABASE ---
    Sub IsiComboPoli()
        Try
            Call BukaKoneksi()
            Dim da As New MySqlDataAdapter("SELECT id_poli, nama_poli FROM tbl_poli ORDER BY nama_poli ASC", Conn)
            Dim dt As New DataTable
            da.Fill(dt)

            cmbpoli.DataSource = dt
            cmbpoli.DisplayMember = "nama_poli"
            cmbpoli.ValueMember = "id_poli"
            cmbpoli.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal memuat data Poli: " & ex.Message)
        End Try
    End Sub

    ' --- 3. GENERATE NO RM OTOMATIS ---
    Function GenerateNoRM() As String
        Call BukaKoneksi()
        Dim tgl As String = Format(Now, "yyyyMM") ' Contoh: 202512
        Dim urutan As String = "001"

        ' Cari nomor terakhir di bulan ini
        Cmd = New MySqlCommand("SELECT no_rm FROM tbl_pasien WHERE no_rm LIKE 'RM" & tgl & "%' ORDER BY no_rm DESC LIMIT 1", Conn)
        Rd = Cmd.ExecuteReader

        If Rd.Read Then
            Dim lastNo As String = Rd.Item("no_rm")
            Dim hitung As Integer = Val(Microsoft.VisualBasic.Right(lastNo, 3)) + 1
            urutan = Format(hitung, "000")
        End If
        Rd.Close()

        Return "RM" & tgl & urutan
    End Function

    ' --- 4. TOMBOL SIMPAN (LOGIKA UTAMA) ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' A. Validasi Input (Wajib Diisi)
        If txtnama.Text = "" Or txtnik.Text = "" Or cmbpoli.SelectedIndex = -1 Or cmbBayar.Text = "" Then
            MsgBox("Mohon lengkapi Nama, NIK, Poli, dan Metode Pembayaran!", MsgBoxStyle.Exclamation, "Data Belum Lengkap")
            Exit Sub
        End If

        ' B. Konfirmasi
        If MsgBox("Pastikan data sudah benar." & vbCrLf & "Simpan data pasien ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            ' C. Generate RM Baru
            NoRMBaru = GenerateNoRM()
            Dim WaktuSekarang As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim TanggalSaja As String = Now.ToString("yyyy-MM-dd")

            ' D. SIMPAN KE TABEL PASIEN
            ' Perhatikan: @tgl_reg diisi otomatis oleh variabel TanggalSaja (System Date)
            Dim QueryPasien As String = "INSERT INTO tbl_pasien (no_rm, nama_pasien, nik, tanggal_lahir, jenis_kelamin, alamat, no_telepon, tgl_registrasi) VALUES (@rm, @nama, @nik, @lahir, @jk, @alamat, @telp, @tgl_reg)"

            Cmd = New MySqlCommand(QueryPasien, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            Cmd.Parameters.AddWithValue("@nik", txtnik.Text)
            Cmd.Parameters.AddWithValue("@lahir", dtplahir.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@jk", cmbkelamin.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            Cmd.Parameters.AddWithValue("@telp", txttelepon.Text)
            Cmd.Parameters.AddWithValue("@tgl_reg", TanggalSaja) ' <--- INI PENGGANTI DTPREGISTRASI
            Cmd.ExecuteNonQuery()

            ' E. SIMPAN KE TABEL JANJI TEMU (Tambahkan Cara Bayar)
            ' Kita simpan cara bayar di sini
            Dim QueryJanji As String = "INSERT INTO tbl_janji_temu (no_rm, id_dokter, id_poli, cara_bayar, tanggal_janji, keluhan, tanggal_dibuat, no_antrian, status) VALUES (@rm, 0, @poli, @bayar, @tgl_janji, @keluhan, @tgl_buat, 0, 'Menunggu')"

            Cmd = New MySqlCommand(QueryJanji, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@poli", cmbpoli.SelectedValue)
            Cmd.Parameters.AddWithValue("@bayar", cmbBayar.Text) ' <--- DATA DARI COMBOBOX PEMBAYARAN
            Cmd.Parameters.AddWithValue("@tgl_janji", TanggalSaja)
            Cmd.Parameters.AddWithValue("@keluhan", "Pendaftaran Pasien Baru")
            Cmd.Parameters.AddWithValue("@tgl_buat", WaktuSekarang)
            Cmd.ExecuteNonQuery()

            ' F. BERHASIL
            MsgBox("Pendaftaran Berhasil!" & vbCrLf & vbCrLf &
                "Nama: " & txtnama.Text & vbCrLf &
                "No. RM: " & NoRMBaru & " (CATAT!)" & vbCrLf &
                "Poli: " & cmbpoli.Text & vbCrLf &
                "Bayar: " & cmbBayar.Text, MsgBoxStyle.Information, "Sukses")

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 5. TOMBOL HAPUS (BATAL TRANSAKSI TERAKHIR) ---
    Private Sub hpsbtn_Click(sender As Object, e As EventArgs) Handles hpsbtn.Click
        If NoRMBaru = "" Then
            MsgBox("Tidak ada data baru yang bisa dihapus.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Batalkan pendaftaran pasien: " & txtnama.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Batal Daftar") = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()
            ' Hapus Janji Temu dulu (Anak)
            Dim Q1 As String = "DELETE FROM tbl_janji_temu WHERE no_rm = @rm"
            Cmd = New MySqlCommand(Q1, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.ExecuteNonQuery()

            ' Hapus Pasien (Induk)
            Dim Q2 As String = "DELETE FROM tbl_pasien WHERE no_rm = @rm"
            Cmd = New MySqlCommand(Q2, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dibatalkan/dihapus.", MsgBoxStyle.Information)
            Call BersihkanForm()

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 6. BERSIHKAN FORM ---
    Sub BersihkanForm()
        txtnama.Clear()
        txtnik.Clear()
        txtalamat.Clear()
        txttelepon.Clear()
        cmbpoli.SelectedIndex = -1
        cmbkelamin.SelectedIndex = -1
        cmbBayar.SelectedIndex = 0 ' Reset ke Umum
        dtplahir.Value = Now
        NoRMBaru = ""
        txtnama.Focus()
    End Sub

    ' --- 7. PERCANTIK TAMPILAN ---
    Sub PercantikTampilan()
        Me.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        Me.BackColor = Color.FromArgb(245, 247, 250)

        For Each ctrl As Control In Me.Controls
            ' Label
            If TypeOf ctrl Is Label Then
                If ctrl.Text.Contains("Pendaftaran") Then
                    ctrl.Font = New Font("Segoe UI", 16, FontStyle.Bold)
                    ctrl.ForeColor = Color.FromArgb(50, 50, 50)
                Else
                    ctrl.ForeColor = Color.FromArgb(80, 80, 80)
                End If
            End If
            ' Input Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).BorderStyle = BorderStyle.FixedSingle
            End If
            ' Buttons
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.Height = 35
                btn.Cursor = Cursors.Hand
                If btn.Text.ToUpper.Contains("SIMPAN") Then
                    btn.BackColor = Color.FromArgb(0, 120, 215)
                    btn.ForeColor = Color.White
                Else
                    btn.BackColor = Color.LightGray
                End If
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBayar.SelectedIndexChanged

    End Sub
End Class