Imports MySql.Data.MySqlClient

Public Class ucbilling

    ' --- VARIABEL GLOBAL ---
    Dim NoRegAktif As String = ""
    Dim GrandTotal As Decimal = 0

    ' --- 1. LOAD AWAL ---
    Private Sub ucbilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Siapkan tabel kanan (Tindakan & Obat) agar bersih
        Call SiapkanTabelKanan()

        ' Load daftar antrian di tabel KIRI
        Call LoadAntrianKasir()

        ' Reset Textbox
        txtTotalTagihan.Text = "0"
        txtUangBayar.Text = "0"

        ' Kunci Textbox
        txtTotalTagihan.ReadOnly = True
        txtdokter.ReadOnly = True
        txtnorm.ReadOnly = True
        txtnoreg.ReadOnly = True
    End Sub

    ' --- 2. PERSIAPAN TABEL KANAN ---
    Sub SiapkanTabelKanan()
        ' A. Tabel Tindakan
        dgvTindakan.Columns.Clear()
        dgvTindakan.Columns.Add("nama", "Rincian Tindakan")
        dgvTindakan.Columns.Add("biaya", "Biaya (Rp)")
        dgvTindakan.Columns.Add("qty", "Qty")
        dgvTindakan.Columns.Add("subtotal", "Subtotal")
        dgvTindakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTindakan.Columns("subtotal").ReadOnly = True

        ' B. Tabel Obat
        dgvObat.Columns.Clear()
        dgvObat.Columns.Add("nama", "Nama Obat")
        dgvObat.Columns.Add("harga", "Harga")
        dgvObat.Columns.Add("qty", "Qty")
        dgvObat.Columns.Add("subtotal", "Subtotal")
        dgvObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvObat.ReadOnly = True
    End Sub

    ' --- 3. LOAD ANTRIAN (TABEL KIRI) ---
    Sub LoadAntrianKasir()
        Try
            Call BukaKoneksi()
            Dim tgl As String = Format(Now, "yyyy-MM-dd")

            ' Ambil data pasien yang belum lunas
            Dim query As String = "SELECT j.no_registrasi, j.no_rm, p.nama_pasien, d.nama_dokter " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "JOIN tbl_dokter d ON j.id_dokter = d.id_dokter " &
                                  "WHERE j.tanggal_janji = '" & tgl & "' AND j.status != 'Lunas'"

            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvAntrian.DataSource = dt

            Call RapikanTabelAntrian()

        Catch ex As Exception
            MsgBox("Gagal Load Antrian: " & ex.Message)
        End Try
    End Sub

    ' --- 4. RAPIKAN TABEL ANTRIAN ---
    Sub RapikanTabelAntrian()
        If dgvAntrian.Rows.Count > 0 Then
            dgvAntrian.Columns("no_registrasi").HeaderText = "No. Reg"
            dgvAntrian.Columns("no_rm").HeaderText = "No. RM"
            dgvAntrian.Columns("nama_pasien").HeaderText = "Pasien"
            dgvAntrian.Columns("nama_dokter").HeaderText = "Dokter"
            dgvAntrian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAntrian.RowHeadersVisible = False
            dgvAntrian.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAntrian.BackgroundColor = Color.White
            dgvAntrian.BorderStyle = BorderStyle.None
        End If
    End Sub

    ' --- 5. TOMBOL PROSES (Pindahkan Data ke Kanan) ---
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dgvAntrian.CurrentRow Is Nothing Then
            MsgBox("Pilih dulu pasien di tabel kiri!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' 1. Ambil Data
            NoRegAktif = dgvAntrian.CurrentRow.Cells("no_registrasi").Value.ToString()
            txtnoreg.Text = NoRegAktif
            txtnorm.Text = dgvAntrian.CurrentRow.Cells("no_rm").Value.ToString()
            txtdokter.Text = dgvAntrian.CurrentRow.Cells("nama_dokter").Value.ToString()

            ' 2. Bersihkan Tabel Kanan
            dgvTindakan.Rows.Clear()
            dgvObat.Rows.Clear()

            ' 3. Default Jasa Dokter (Kasir bisa hapus/edit nanti)
            dgvTindakan.Rows.Add("Jasa Dokter Umum", "50000", "1", "50000")
            dgvTindakan.Rows.Add("Biaya Admin", "10000", "1", "10000")

            ' 4. Load Obat (PENTING)
            Call HitungBiayaObat()

            ' 5. Hitung Total Akhir
            Call HitungGrandTotal()

        Catch ex As Exception
            MsgBox("Error Proses: " & ex.Message)
        End Try
    End Sub

    ' --- 6. LOAD OBAT (BAGIAN UTAMA PERBAIKAN) ---
    Sub HitungBiayaObat()
        Try
            Call BukaKoneksi()

            ' Query Join 3 Tabel: Farmasi -> Detail -> Obat
            ' Pastikan nama kolom 'id_resep' BENAR ada di database Anda
            Dim query As String = "SELECT o.nama_obat, o.harga_satuan, fd.jumlah, fd.subtotal " &
                                  "FROM tbl_farmasi f " &
                                  "JOIN tbl_farmasi_detail fd ON f.id_resep = fd.id_resep " &
                                  "JOIN tbl_obat o ON fd.id_obat = o.id_obat " &
                                  "WHERE f.no_registrasi = '" & NoRegAktif & "'"

            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader

            Dim AdaData As Boolean = False

            While Rd.Read
                AdaData = True
                ' Cek Null agar tidak error
                Dim Nama As String = If(IsDBNull(Rd("nama_obat")), "-", Rd("nama_obat").ToString())
                Dim Harga As Decimal = If(IsDBNull(Rd("harga_satuan")), 0, CDec(Rd("harga_satuan")))
                Dim Jml As Integer = If(IsDBNull(Rd("jumlah")), 0, CInt(Rd("jumlah")))
                Dim SubTotal As Decimal = If(IsDBNull(Rd("subtotal")), 0, CDec(Rd("subtotal")))

                ' Masukkan ke Tabel
                dgvObat.Rows.Add(Nama, FormatNumber(Harga, 0), Jml, FormatNumber(SubTotal, 0))
            End While
            Rd.Close()

            ' Debugging: Beri tahu jika obat tidak ketemu
            If AdaData = False Then
                ' MsgBox("Info: Tidak ada data obat untuk pasien ini (Mungkin belum ditebus di Farmasi).", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Gagal Load Obat: " & ex.Message & vbCrLf & "Pastikan kolom 'id_resep' ada di tabel tbl_farmasi.")
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    ' --- 7. EDIT MANUAL TINDAKAN ---
    Private Sub dgvTindakan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTindakan.CellEndEdit
        Try
            Dim row As DataGridViewRow = dgvTindakan.Rows(e.RowIndex)

            ' Gunakan Double.Parse agar aman membaca angka format "10,000"
            Dim BiayaStr As String = row.Cells("biaya").Value.ToString().Replace(",", "")
            Dim Biaya As Decimal = Val(BiayaStr)

            Dim Qty As Integer = Val(row.Cells("qty").Value)

            row.Cells("subtotal").Value = FormatNumber(Biaya * Qty, 0)

            Call HitungGrandTotal()
        Catch ex As Exception
        End Try
    End Sub

    ' --- 8. HITUNG GRAND TOTAL ---
    Sub HitungGrandTotal()
        GrandTotal = 0

        ' Hitung Tindakan
        For Each row As DataGridViewRow In dgvTindakan.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                ' Hapus koma sebelum dijumlahkan
                Dim Nilai As String = row.Cells("subtotal").Value.ToString().Replace(",", "")
                GrandTotal += Val(Nilai)
            End If
        Next

        ' Hitung Obat
        For Each row As DataGridViewRow In dgvObat.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                Dim Nilai As String = row.Cells("subtotal").Value.ToString().Replace(",", "")
                GrandTotal += Val(Nilai)
            End If
        Next

        txtTotalTagihan.Text = FormatNumber(GrandTotal, 0)
    End Sub

    ' --- 9. BAYAR ---
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        If NoRegAktif = "" Then Exit Sub

        Dim UangBayar As Decimal = Val(txtUangBayar.Text.Replace(",", ""))

        If UangBayar < GrandTotal Then
            MsgBox("Uang Kurang!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim Kembalian As Decimal = UangBayar - GrandTotal

        If MsgBox("LUNAS? Kembalian: Rp " & FormatNumber(Kembalian, 0), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()

                ' Update Janji Temu
                Dim q1 As String = "UPDATE tbl_janji_temu SET status='Lunas' WHERE no_registrasi='" & NoRegAktif & "'"
                Dim cmdAsal As New MySqlCommand(q1, Conn)
                cmdAsal.ExecuteNonQuery()

                ' Update Farmasi
                Dim q2 As String = "UPDATE tbl_farmasi SET status_bayar='Lunas' WHERE no_registrasi='" & NoRegAktif & "'"
                Dim cmdFarmasi As New MySqlCommand(q2, Conn)
                cmdFarmasi.ExecuteNonQuery()

                MsgBox("Pembayaran Berhasil.", MsgBoxStyle.Information)

                ' Refresh Halaman
                Call ucbilling_Load(Nothing, Nothing)
                NoRegAktif = ""
                dgvTindakan.Rows.Clear()
                dgvObat.Rows.Clear()

            Catch ex As Exception
                MsgBox("Error Bayar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormCari As New pilihobatkasir
        If FormCari.ShowDialog() = DialogResult.OK Then
            ' Data diambil dari FormCari.IDObatDipilih, dll.
        End If
    End Sub
End Class