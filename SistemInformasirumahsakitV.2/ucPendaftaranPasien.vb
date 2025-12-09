Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class ucPendaftaranPasien
    Dim NoRMBaru As String = ""


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ucPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsiComboPoli()

        ' Set tanggal registrasi otomatis hari ini
        dtpRegistrasi.Value = Now
        dtpRegistrasi.Enabled = False ' Kunci agar tidak diubah
        Call PercantikTampilan()

    End Sub

    Private Sub CentralPanel_Paint(sender As Object, e As PaintEventArgs) Handles CentralPanel.Paint

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpoli.SelectedIndexChanged

    End Sub
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

    Function GenerateNoRM() As String
        Call BukaKoneksi()
        Dim tgl As String = Format(Now, "yyyyMM") ' Contoh: 202505
        Dim urutan As String = "001"

        ' Cari nomor terakhir di bulan ini
        Cmd = New MySqlCommand("SELECT no_rm FROM tbl_pasien WHERE no_rm LIKE 'RM" & tgl & "%' ORDER BY no_rm DESC LIMIT 1", Conn)
        Rd = Cmd.ExecuteReader

        If Rd.Read Then
            ' Jika ada, ambil 3 digit terakhir, tambah 1
            Dim lastNo As String = Rd.Item("no_rm")
            Dim hitung As Integer = Val(Microsoft.VisualBasic.Right(lastNo, 3)) + 1
            urutan = Format(hitung, "000")
        End If
        Rd.Close()

        ' Kembalikan hasil gabungan (Contoh: RM202505002)
        Return "RM" & tgl & urutan
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' --- VALIDASI INPUT ---
        If txtNama.Text = "" Or txtNIK.Text = "" Or cmbpoli.SelectedIndex = -1 Then
            MsgBox("Mohon lengkapi Nama, NIK, dan Poli Tujuan!", MsgBoxStyle.Exclamation, "Data Belum Lengkap")
            Exit Sub
        End If

        ' --- KONFIRMASI ---
        If MsgBox("Apakah data sudah benar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            ' 1. GENERATE NOMOR RM BARU
            NoRMBaru = GenerateNoRM()

            ' 2. SIMPAN KE TABEL PASIEN
            Dim QueryPasien As String = "INSERT INTO tbl_pasien (no_rm, nama_pasien, nik, tanggal_lahir, jenis_kelamin, alamat, no_telepon, tgl_registrasi) VALUES (@rm, @nama, @nik, @lahir, @jk, @alamat, @telp, @tgl_reg)"

            Cmd = New MySqlCommand(QueryPasien, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            Cmd.Parameters.AddWithValue("@nik", txtNIK.Text)
            Cmd.Parameters.AddWithValue("@lahir", dtpLahir.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@jk", cmbKelamin.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@telp", txtTelepon.Text)
            Cmd.Parameters.AddWithValue("@tgl_reg", Now.ToString("yyyy-MM-dd"))
            Cmd.ExecuteNonQuery()

            ' 3. SIMPAN KE TABEL JANJI TEMU (ANTRIAN POLI)
            ' Status default: 'Menunggu'. Dokter sementara kita set 0 atau null jika belum dipilih, tapi karena wajib poli, kita catat Polinya.
            ' Asumsi: id_dokter nanti diupdate saat pasien dipanggil perawat/dokter, atau bisa dipilih di form ini jika mau.

            Dim QueryJanji As String = "INSERT INTO tbl_janji_temu (no_rm, id_dokter, id_poli, tanggal_janji, keluhan, tanggal_dibuat, no_antrian, status) VALUES (@rm, @dokter, @poli, @tgl_janji, @keluhan, @tgl_buat, @antrian, 'Menunggu')"

            Cmd = New MySqlCommand(QueryJanji, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@dokter", 0)
            Cmd.Parameters.AddWithValue("@poli", cmbpoli.SelectedValue) ' Mengambil ID Poli dari ValueMember
            Cmd.Parameters.AddWithValue("@tgl_janji", Now.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@keluhan", "Pendaftaran Pasien Baru")
            Cmd.Parameters.AddWithValue("@tgl_buat", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@antrian", 0)
            Cmd.ExecuteNonQuery()

            ' --- BERHASIL ---
            MsgBox("Pendaftaran Berhasil!" & vbCrLf & vbCrLf &
               "Nama: " & txtNama.Text & vbCrLf &
               "No. RM: " & NoRMBaru & " (CATAT INI!)" & vbCrLf &
               "Tujuan: " & cmbpoli.Text, MsgBoxStyle.Information, "Sukses")


        Catch ex As Exception
            MsgBox("Terjadi Kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnik.TextChanged

    End Sub

    ' --- SUBRUTIN UNTUK MEMPERCANTIK TAMPILAN (MODERN LOOK) ---
    Sub PercantikTampilan()
        ' 1. FONT & BACKGROUND
        ' Gunakan ukuran 9pt agar terlihat lebih profesional dan tidak "Raksasa"
        Me.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        Me.BackColor = Color.FromArgb(245, 247, 250) ' Putih keabu-abuan (Soft)

        For Each ctrl As Control In Me.Controls
            ' --- LABEL (Tulisan) ---
            If TypeOf ctrl Is Label Then
                ' Label judul dibuat beda sendiri
                If ctrl.Name.ToLower().Contains("judul") Or ctrl.Text.Contains("Pendaftaran") Then
                    ctrl.Font = New Font("Segoe UI", 16, FontStyle.Bold)
                    ctrl.ForeColor = Color.FromArgb(50, 50, 50) ' Hitam soft
                Else
                    ctrl.ForeColor = Color.FromArgb(80, 80, 80) ' Abu tua
                End If
            End If

            ' --- TEXTBOX / COMBO / DATE (Inputan) ---
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Font = New Font("Segoe UI", 10, FontStyle.Regular) ' Isi inputan sedikit lebih besar dari label

                ' Trik agar TextBox tidak terlihat gepeng (Flat)
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).BorderStyle = BorderStyle.FixedSingle
                End If
            End If

            ' --- TOMBOL (Button) ---
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.Cursor = Cursors.Hand
                btn.Height = 35 ' Tinggi tombol dipatok 35px agar ramping
                btn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                btn.ForeColor = Color.White

                ' Pewarnaan Tombol
                If btn.Text.ToUpper().Contains("SIMPAN") Then
                    btn.BackColor = Color.FromArgb(0, 120, 215) ' Biru Windows 10
                ElseIf btn.Text.ToUpper().Contains("HAPUS") Or btn.Text.ToUpper().Contains("BATAL") Then
                    btn.BackColor = Color.FromArgb(220, 53, 69) ' Merah Soft
                    btn.ForeColor = Color.White
                Else
                    btn.BackColor = Color.LightGray
                    btn.ForeColor = Color.Black
                End If
            End If
        Next
    End Sub

    Private Sub hpsbtn_Click(sender As Object, e As EventArgs) Handles hpsbtn.Click
        If NoRMBaru = "" Then
            MsgBox("Tidak ada data baru yang bisa dihapus/dibatalkan.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' 2. Konfirmasi penghapusan (PENTING)
        If MsgBox("Apakah Anda yakin ingin membatalkan/menghapus data pasien: " & txtnama.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Hapus Data") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Call BukaKoneksi()

            ' 3. HAPUS DARI TABEL ANAK DULU (Janji Temu)
            ' Kita hapus berdasarkan no_rm
            Dim QueryHapusJanji As String = "DELETE FROM tbl_janji_temu WHERE no_rm = @rm"
            Cmd = New MySqlCommand(QueryHapusJanji, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.ExecuteNonQuery()

            ' 4. BARU HAPUS DARI TABEL INDUK (Pasien)
            Dim QueryHapusPasien As String = "DELETE FROM tbl_pasien WHERE no_rm = @rm"
            Cmd = New MySqlCommand(QueryHapusPasien, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus dari database.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Gagal menghapus: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub
    Sub BersihkanForm()
        txtnama.Clear()
        txtnik.Clear()
        txtalamat.Clear()
        txttelepon.Clear()
        cmbpoli.SelectedIndex = -1
        cmbkelamin.SelectedIndex = -1
        dtplahir.Value = Now

        ' Reset variabel NoRMBaru agar tombol hapus tidak salah hapus data
        NoRMBaru = ""

        txtnama.Focus() ' Kembalikan kursor ke nama
    End Sub
End Class
