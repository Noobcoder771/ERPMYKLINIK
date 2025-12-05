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
    End Sub
    Private Sub ucPendaftaranPasien_Resize(sender As Object, e As EventArgs, y As Integer) Handles Me.Resize
        If CentralPanel IsNot Nothing Then
            Dim x As Integer = (Me.Width - CentralPanel.Width) / 2 ' <-- Ganti CenterPanel ke CentralPanel
            CentralPanel.Location = New Point(x, y)
        End If
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
            Dim QueryPasien As String = "INSERT INTO tbl_pasien (no_rm, nama_pasien, nik, tgl_lahir, jk, alamat, no_telp, tgl_registrasi) VALUES (@rm, @nama, @nik, @lahir, @jk, @alamat, @telp, @tgl_reg)"

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

            Dim QueryJanji As String = "INSERT INTO tbl_janji_temu (no_rm, id_poli, tgl_janji, status, no_antrian) VALUES (@rm, @poli, @tgl, 'Menunggu', 0)"
            ' Catatan: no_antrian 0 nanti diurus sistem antrian/display

            Cmd = New MySqlCommand(QueryJanji, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@poli", cmbpoli.SelectedValue) ' Mengambil ID Poli dari ValueMember
            Cmd.Parameters.AddWithValue("@tgl", Now.ToString("yyyy-MM-dd"))
            Cmd.ExecuteNonQuery()

            ' --- BERHASIL ---
            MsgBox("Pendaftaran Berhasil!" & vbCrLf & vbCrLf &
               "Nama: " & txtNama.Text & vbCrLf &
               "No. RM: " & NoRMBaru & " (CATAT INI!)" & vbCrLf &
               "Tujuan: " & cmbpoli.Text, MsgBoxStyle.Information, "Sukses")

            ' 4. BERSIHKAN FORM
            txtNama.Clear()
            txtNIK.Clear()
            txtAlamat.Clear()
            txtTelepon.Clear()
            cmbpoli.SelectedIndex = -1
            txtNama.Focus()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnik.TextChanged

    End Sub
End Class
