Imports MySql.Data.MySqlClient

Public Class ucjanjitemu

    Dim PasienTerpilih As String = ""

    Private Sub ucjanjitemu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCariRM.Text = "Masukan No. RM"
        txtCariRM.ForeColor = Color.Gray
        pnlHasil.Visible = False

        dtpjanji.MinDate = Now

        Call IsiComboPoli()
    End Sub

    Sub IsiComboPoli()
        Try
            Call BukaKoneksi()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbl_poli ORDER BY nama_poli", Conn)
            Dim dt As New DataTable
            da.Fill(dt)

            RemoveHandler cmbPoli.SelectedIndexChanged, AddressOf cmbPoli_SelectedIndexChanged

            cmbPoli.DisplayMember = "nama_poli"
            cmbPoli.ValueMember = "id_poli"

            cmbPoli.DataSource = dt
            cmbPoli.SelectedIndex = -1

            AddHandler cmbPoli.SelectedIndexChanged, AddressOf cmbPoli_SelectedIndexChanged

        Catch ex As Exception
            MsgBox("Gagal Load Poli: " & ex.Message)
        End Try
    End Sub

    Sub FilterDokterOtomatis()
        If cmbPoli.SelectedIndex = -1 Or cmbPoli.SelectedValue Is Nothing Then Exit Sub

        Try
            Dim hariIni As String = GetHariIndo(dtpjanji.Value)
            Dim idPoliDipilih As String = cmbPoli.SelectedValue.ToString()

            Call BukaKoneksi()

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

            dt.Columns.Add("Tampilan", GetType(String))

            For Each row As DataRow In dt.Rows
                Dim jamMulai As String = row("jam_mulai").ToString()
                Dim jamSelesai As String = row("jam_selesai").ToString()

                If jamMulai.Length > 5 Then jamMulai = jamMulai.Substring(0, 5)
                If jamSelesai.Length > 5 Then jamSelesai = jamSelesai.Substring(0, 5)
                row("Tampilan") = row("nama_dokter").ToString() & " | " & jamMulai & "-" & jamSelesai
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
            MsgBox("Error Filter Dokter: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbPoli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPoli.SelectedIndexChanged
        Call FilterDokterOtomatis()
    End Sub

    Private Sub dtpjanji_ValueChanged(sender As Object, e As EventArgs) Handles dtpjanji.ValueChanged
        Call FilterDokterOtomatis()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCariRM.Text = "" Or txtCariRM.Text = "Masukan No. RM" Then
            MsgBox("Isi No RM dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()
            Dim query As String = "SELECT * FROM tbl_pasien WHERE no_rm = @cari OR nama_pasien LIKE @nama"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@cari", txtCariRM.Text)
            Cmd.Parameters.AddWithValue("@nama", "%" & txtCariRM.Text & "%")

            Rd = Cmd.ExecuteReader
            If Rd.Read() Then
                PasienTerpilih = Rd("no_rm").ToString()
                pnlHasil.Visible = True
                lblNamaPasien.Text = Rd("nama_pasien").ToString()
                lblDetailPasien.Text = "No RM: " & PasienTerpilih & vbCrLf & Rd("alamat").ToString()
            Else
                MsgBox("Pasien tidak ditemukan.")
                pnlHasil.Visible = False
                PasienTerpilih = ""
            End If
            Rd.Close()
        Catch ex As Exception
            MsgBox("Error Cari: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub btnBuatJanji_Click(sender As Object, e As EventArgs) Handles btnBuatJanji.Click
        If PasienTerpilih = "" Or cmbDokter.SelectedIndex = -1 Then
            MsgBox("Data belum lengkap (Pasien/Dokter)!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()
            Dim NoReg As String = GenerateNoRegistrasi()
            Dim Keluhan As String = If(txtKeluhan.Text = "", "-", txtKeluhan.Text)

            Dim Query As String = "INSERT INTO tbl_janji_temu (no_registrasi, no_rm, id_dokter, id_poli, tanggal_janji, keluhan, tanggal_dibuat, status, no_antrian) VALUES (@reg, @rm, @dr, @poli, @tgl, @keluhan, @dibuat, 'Menunggu', 0)"

            Cmd = New MySqlCommand(Query, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoReg)
            Cmd.Parameters.AddWithValue("@rm", PasienTerpilih)
            Cmd.Parameters.AddWithValue("@dr", cmbDokter.SelectedValue)
            Cmd.Parameters.AddWithValue("@poli", cmbPoli.SelectedValue)
            Cmd.Parameters.AddWithValue("@tgl", dtpjanji.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@keluhan", Keluhan)
            Cmd.Parameters.AddWithValue("@dibuat", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            Cmd.ExecuteNonQuery()

            MsgBox("Sukses! No Reg: " & NoReg)

            txtCariRM.Text = "Masukan No. RM"
            txtCariRM.ForeColor = Color.Gray
            pnlHasil.Visible = False
            txtKeluhan.Clear()
            cmbPoli.SelectedIndex = -1
            cmbDokter.DataSource = Nothing
            PasienTerpilih = ""

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

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