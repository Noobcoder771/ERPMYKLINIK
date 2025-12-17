Imports MySql.Data.MySqlClient

Public Class ucPendaftaranPasien
    Dim NoRMBaru As String = ""

    Private Sub ucPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsiComboPoli()
        Call PercantikTampilan()

        cmbBayar.Items.Clear()
        cmbBayar.Items.Add("Umum / Tunai")
        cmbBayar.Items.Add("BPJS Kesehatan")
        cmbBayar.Items.Add("Asuransi Lain")
        cmbBayar.SelectedIndex = 0
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
        Dim tgl As String = Format(Now, "yyyyMM")
        Dim urutan As String = "001"

        Dim CmdRM As New MySqlCommand("SELECT no_rm FROM tbl_pasien WHERE no_rm LIKE 'RM" & tgl & "%' ORDER BY no_rm DESC LIMIT 1", Conn)
        Dim RdRM As MySqlDataReader = CmdRM.ExecuteReader

        If RdRM.Read Then
            Dim lastNo As String = RdRM.Item("no_rm")
            Dim hitung As Integer = Val(Microsoft.VisualBasic.Right(lastNo, 3)) + 1
            urutan = Format(hitung, "000")
        End If
        RdRM.Close()

        Return "RM" & tgl & urutan
    End Function

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
            MsgBox("Error Generate REG: " & ex.Message)
        End Try
        Return noReg
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtnama.Text = "" Or txtnik.Text = "" Or cmbpoli.SelectedIndex = -1 Or cmbBayar.Text = "" Then
            MsgBox("Mohon lengkapi Nama, NIK, Poli, dan Metode Pembayaran!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Simpan data pasien ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()

            NoRMBaru = GenerateNoRM()
            Dim NoRegBaru As String = GenerateNoRegistrasi()

            Dim WaktuSekarang As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim TanggalSaja As String = Now.ToString("yyyy-MM-dd")

            Dim QueryPasien As String = "INSERT INTO tbl_pasien (no_rm, nama_pasien, nik, tanggal_lahir, jenis_kelamin, alamat, no_telepon, tgl_registrasi) VALUES (@rm, @nama, @nik, @lahir, @jk, @alamat, @telp, @tgl_reg)"

            Cmd = New MySqlCommand(QueryPasien, Conn)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            Cmd.Parameters.AddWithValue("@nik", txtnik.Text)
            Cmd.Parameters.AddWithValue("@lahir", dtplahir.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@jk", cmbkelamin.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            Cmd.Parameters.AddWithValue("@telp", txttelepon.Text)
            Cmd.Parameters.AddWithValue("@tgl_reg", TanggalSaja)
            Cmd.ExecuteNonQuery()

            Dim QueryJanji As String = "INSERT INTO tbl_janji_temu (no_registrasi, no_rm, id_dokter, id_poli, cara_bayar, tanggal_janji, keluhan, tanggal_dibuat, no_antrian, status) VALUES (@reg, @rm, 0, @poli, @bayar, @tgl_janji, @keluhan, @tgl_buat, 0, 'Menunggu')"

            Cmd = New MySqlCommand(QueryJanji, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoRegBaru)
            Cmd.Parameters.AddWithValue("@rm", NoRMBaru)
            Cmd.Parameters.AddWithValue("@poli", cmbpoli.SelectedValue)
            Cmd.Parameters.AddWithValue("@bayar", cmbBayar.Text)
            Cmd.Parameters.AddWithValue("@tgl_janji", TanggalSaja)
            Cmd.Parameters.AddWithValue("@keluhan", "Pendaftaran Pasien Baru")
            Cmd.Parameters.AddWithValue("@tgl_buat", WaktuSekarang)
            Cmd.ExecuteNonQuery()

            MsgBox("Pendaftaran Berhasil!" & vbCrLf &
                "Nama: " & txtnama.Text & vbCrLf &
                "No. RM: " & NoRMBaru & vbCrLf &
                "No. Reg: " & NoRegBaru, MsgBoxStyle.Information)

            Call BersihkanForm()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub hpsbtn_Click(sender As Object, e As EventArgs) Handles hpsbtn.Click
        Call BersihkanForm()
    End Sub

    Sub BersihkanForm()
        txtnama.Clear()
        txtnik.Clear()
        txtalamat.Clear()
        txttelepon.Clear()
        cmbpoli.SelectedIndex = -1
        cmbkelamin.SelectedIndex = -1
        cmbBayar.SelectedIndex = 0
        dtplahir.Value = Now
        NoRMBaru = ""
        txtnama.Focus()
    End Sub

    Sub PercantikTampilan()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).BorderStyle = BorderStyle.FixedSingle
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
            End If
        Next
    End Sub

    Private Sub CentralPanel_Paint(sender As Object, e As PaintEventArgs) Handles CentralPanel.Paint

    End Sub
End Class