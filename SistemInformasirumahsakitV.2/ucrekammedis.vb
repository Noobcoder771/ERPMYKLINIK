Imports MySql.Data.MySqlClient

Public Class ucRekamMedis

    Private Sub ucRekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BersihkanLayar()
        Call RapihkanTampilan()

        If ModulKoneksi.NoRMPasienTerpilih <> "" Then
            txtcari.Text = ModulKoneksi.NoRMPasienTerpilih
            Call CariRiwayatPasien(ModulKoneksi.NoRMPasienTerpilih)
        End If
    End Sub

    Sub CariRiwayatPasien(KataKunci As String)
        Try
            Call BukaKoneksi()

            Dim query As String = "SELECT r.no_registrasi, r.id_rekam_medis, r.tgl_periksa, r.no_rm, p.nama_pasien, r.keluhan_subjektif " &
                                  "FROM tbl_rekam_medis r " &
                                  "JOIN tbl_pasien p ON r.no_rm = p.no_rm " &
                                  "WHERE r.no_rm LIKE @kata OR p.nama_pasien LIKE @kata " &
                                  "ORDER BY r.tgl_periksa DESC"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@kata", "%" & KataKunci & "%")

            Dim da As New MySqlDataAdapter(Cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvRiwayat.DataSource = dt
            Call AturKolomTabel()

        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtcari.Text = "" Then
            MsgBox("Ketik Nama Pasien atau No. RM dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()

            Dim query As String = "SELECT r.no_registrasi, r.id_rekam_medis, r.tgl_periksa, p.nama_pasien, d.nama_dokter " &
                                  "FROM tbl_rekam_medis r " &
                                  "JOIN tbl_pasien p ON r.no_rm = p.no_rm " &
                                  "JOIN tbl_dokter d ON r.id_dokter = d.id_dokter " &
                                  "WHERE p.nama_pasien LIKE @cari OR p.no_rm LIKE @cari " &
                                  "ORDER BY r.tgl_periksa DESC"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@cari", "%" & txtcari.Text & "%")

            Dim da As New MySqlDataAdapter(Cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvRiwayat.DataSource = dt
            Call AturKolomTabel()

        Catch ex As Exception
            MsgBox("Gagal Cari: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Sub AturKolomTabel()
        If dgvRiwayat.Columns.Count > 0 Then
            If dgvRiwayat.Columns.Contains("id_rekam_medis") Then dgvRiwayat.Columns("id_rekam_medis").Visible = False
            If dgvRiwayat.Columns.Contains("no_registrasi") Then dgvRiwayat.Columns("no_registrasi").Visible = False

            If dgvRiwayat.Columns.Contains("tgl_periksa") Then
                dgvRiwayat.Columns("tgl_periksa").HeaderText = "Tgl Berobat"
                dgvRiwayat.Columns("tgl_periksa").DefaultCellStyle.Format = "dd-MMM-yyyy"
            End If

            If dgvRiwayat.Columns.Contains("nama_pasien") Then dgvRiwayat.Columns("nama_pasien").HeaderText = "Pasien"
            If dgvRiwayat.Columns.Contains("nama_dokter") Then dgvRiwayat.Columns("nama_dokter").HeaderText = "Dokter"
        End If
    End Sub

    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim ID As String = dgvRiwayat.Rows(e.RowIndex).Cells("id_rekam_medis").Value.ToString()
            Call TampilkanDetailLengkap(ID)

        Catch ex As Exception
            MsgBox("Error Baca Detail: " & ex.Message)
        End Try
    End Sub

    Sub TampilkanDetailLengkap(ID As String)
        Try
            Call BukaKoneksi()
            Dim query As String = "SELECT diagnosa, tindakan, resep_obat, alergi_obat FROM tbl_rekam_medis WHERE id_rekam_medis = @id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", ID)
            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                txtDiagnosa.Text = Rd("diagnosa").ToString()
                txtalergi.Text = Rd("alergi_obat").ToString()

                txttindakan.Text = Rd("tindakan").ToString()
                txtResepView.Text = Rd("resep_obat").ToString()
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Gagal ambil detail: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtDiagnosa.Text = "" Then
            MsgBox("Pilih data riwayat pasien dari tabel terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Kirim data ini ke bagian Kasir/Billing?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub

        Try
            Call BukaKoneksi()
            If dgvRiwayat.CurrentRow Is Nothing Then
                MsgBox("Silakan klik baris tabel pasien dulu.")
                Exit Sub
            End If

            Dim NoReg As String = dgvRiwayat.CurrentRow.Cells("no_registrasi").Value.ToString()

            Dim query As String = "UPDATE tbl_janji_temu SET status = 'Menunggu Pembayaran' WHERE no_registrasi = @reg"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@reg", NoReg)
            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dikirim ke Kasir.", MsgBoxStyle.Information)

            Call BersihkanLayar()

        Catch ex As Exception
            MsgBox("Gagal kirim ke kasir: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call BersihkanLayar()
    End Sub

    Sub BersihkanLayar()
        txtcari.Clear()
        dgvRiwayat.DataSource = Nothing
        txtDiagnosa.Clear()
        txtalergi.Clear()
        txttindakan.Clear()
        txtResepView.Clear()
    End Sub

    Sub RapihkanTampilan()
        With dgvRiwayat
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215)
            .DefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
        End With

        AturGayaTextBox(txtDiagnosa)
        AturGayaTextBox(txtalergi)
        AturGayaTextBox(txttindakan)
        AturGayaTextBox(txtResepView)
    End Sub

    Sub AturGayaTextBox(txt As TextBox)
        txt.ReadOnly = True
        txt.BackColor = Color.White
        txt.Font = New Font("Segoe UI", 10)
        txt.BorderStyle = BorderStyle.FixedSingle
    End Sub

End Class