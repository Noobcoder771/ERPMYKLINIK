Imports MySql.Data.MySqlClient

Public Class ucRekamMedis

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub ucRekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BersihkanLayar()
        Call RapihkanTampilan() ' <--- Ini rahasia tampilan cantik
    End Sub

    ' --- 2. LOGIKA PENCARIAN (PANEL KIRI) ---
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            MsgBox("Ketik Nama Pasien atau No. RM dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi()

            ' Ambil data penting saja untuk tabel ringkasan
            Dim query As String = "SELECT r.id_rekam_medis, r.tgl_periksa, p.nama_pasien, d.nama_dokter " &
                                  "FROM tbl_rekam_medis r " &
                                  "JOIN tbl_pasien p ON r.no_rm = p.no_rm " &
                                  "JOIN tbl_dokter d ON r.id_dokter = d.id_dokter " &
                                  "WHERE p.nama_pasien LIKE @cari OR p.no_rm LIKE @cari " &
                                  "ORDER BY r.tgl_periksa DESC"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")

            Dim da As New MySqlDataAdapter(Cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvRiwayat.DataSource = dt

            ' Rapikan Judul Kolom
            If dgvRiwayat.Columns.Count > 0 Then
                dgvRiwayat.Columns("id_rekam_medis").Visible = False ' Sembunyikan ID
                dgvRiwayat.Columns("tgl_periksa").HeaderText = "Tgl Berobat"
                dgvRiwayat.Columns("nama_pasien").HeaderText = "Pasien"
                dgvRiwayat.Columns("nama_dokter").HeaderText = "Dokter"

                ' Format Tanggal biar rapi (dd-MM-yyyy)
                dgvRiwayat.Columns("tgl_periksa").DefaultCellStyle.Format = "dd-MMM-yyyy"
            End If

        Catch ex As Exception
            MsgBox("Gagal Cari: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 3. SAAT RIWAYAT DIKLIK (ISI PANEL KANAN) ---
    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            ' Ambil ID Rekam Medis yang tersembunyi
            Dim ID As String = dgvRiwayat.Rows(e.RowIndex).Cells("id_rekam_medis").Value.ToString()

            Call TampilkanDetailLengkap(ID)

        Catch ex As Exception
            MsgBox("Error Baca Detail: " & ex.Message)
        End Try
    End Sub

    Sub TampilkanDetailLengkap(ID As String)
        Try
            Call BukaKoneksi()

            ' Ambil semua data text (Diagnosa, Tindakan, Resep, Alergi)
            Dim query As String = "SELECT diagnosa, tindakan, resep_obat, alergi_obat FROM tbl_rekam_medis WHERE id_rekam_medis = @id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", ID)
            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                ' Masukkan ke kotak-kotak di kanan
                txtDiagnosa.Text = Rd("diagnosa").ToString()
                txtalergi.Text = Rd("alergi_obat").ToString()

                ' Tindakan Singkat
                txttindakan.Text = Rd("tindakan").ToString()

                ' Resep Panjang (Di Kotak Besar Bawah)
                txtResepView.Text = Rd("resep_obat").ToString()
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox("Gagal ambil detail: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 4. BEBERSIH & RESET ---
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call BersihkanLayar()
    End Sub

    Sub BersihkanLayar()
        txtCari.Clear()
        dgvRiwayat.DataSource = Nothing
        txtDiagnosa.Clear()
        txtalergi.Clear()
        txttindakan.Clear()
        txtResepView.Clear()
    End Sub

    ' --- 5. RAHASIA TAMPILAN CANTIK & SEIMBANG (UI CODE) ---
    Sub RapihkanTampilan()
        ' A. Rapihkan Tabel Riwayat (Kiri)
        With dgvRiwayat
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240) ' Baris selang-seling abu muda
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215) ' Biru Windows
            .DefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Agar kolom memenuhi lebar panel
            .RowHeadersVisible = False ' Hilangkan kotak kosong di paling kiri
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
        End With

        ' B. Rapihkan TextBox (Kanan) agar terlihat konsisten
        AturGayaTextBox(txtDiagnosa)
        AturGayaTextBox(txtalergi)
        AturGayaTextBox(txttindakan)
        AturGayaTextBox(txtResepView)
    End Sub

    ' Helper kecil untuk gaya TextBox
    Sub AturGayaTextBox(txt As TextBox)
        txt.ReadOnly = True
        txt.BackColor = Color.White ' Paksa putih jangan abu-abu
        txt.Font = New Font("Segoe UI", 10)
        txt.BorderStyle = BorderStyle.FixedSingle
    End Sub

End Class