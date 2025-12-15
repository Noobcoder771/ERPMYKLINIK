Imports MySql.Data.MySqlClient

Public Class ucbilling

    ' Variabel Global
    Dim NoRegAktif As String = ""
    Dim GrandTotal As Decimal = 0

    ' --- 1. LOAD AWAL ---
    Private Sub ucKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SiapkanTabel()
        Call LoadAntrianKasir()

        ' Kunci Inputan Identitas
        txtTotalTagihan.Text = "0"
        txtUangBayar.Text = "0"
        txtTotalTagihan.ReadOnly = True

        txtdokter.ReadOnly = True
        txtNoRM.ReadOnly = True
        txtNoReg.ReadOnly = True
    End Sub

    ' --- 2. PERSIAPAN TABEL (MODIFIKASI: Editable) ---
    Sub SiapkanTabel()
        ' A. Tabel Tindakan (BISA DIEDIT)
        dgvTindakan.Columns.Clear()
        dgvTindakan.Columns.Add("nama", "Rincian Tindakan")
        dgvTindakan.Columns.Add("biaya", "Biaya (Rp)")
        dgvTindakan.Columns.Add("qty", "Qty")
        dgvTindakan.Columns.Add("subtotal", "Subtotal")

        dgvTindakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Kunci kolom Subtotal saja (karena ini hasil hitungan)
        dgvTindakan.Columns("subtotal").ReadOnly = True
        ' Kolom Nama, Biaya, Qty BIARKAN BISA DIEDIT (ReadOnly = False)

        ' B. Tabel Obat (Tetap ReadOnly demi keamanan stok)
        dgvObat.Columns.Clear()
        dgvObat.Columns.Add("nama", "Nama Obat")
        dgvObat.Columns.Add("harga", "Harga")
        dgvObat.Columns.Add("qty", "Qty")
        dgvObat.Columns.Add("subtotal", "Subtotal")
        dgvObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvObat.ReadOnly = True
    End Sub

    ' --- 3. LOAD ANTRIAN ---
    Sub LoadAntrianKasir()
        Try
            Call BukaKoneksi()
            Dim tgl As String = Format(Now, "yyyy-MM-dd")

            Dim query As String = "SELECT j.no_registrasi, j.no_rm, p.nama_pasien, d.nama_dokter " &
                                  "FROM tbl_janji_temu j " &
                                  "JOIN tbl_pasien p ON j.no_rm = p.no_rm " &
                                  "JOIN tbl_dokter d ON j.id_dokter = d.id_dokter " &
                                  "WHERE j.tanggal_janji = '" & tgl & "' AND j.status != 'Lunas'"

            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvAntrian.DataSource = dt
            dgvAntrian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal Load Antrian: " & ex.Message)
        End Try
    End Sub

    ' --- 4. SAAT KLIK PASIEN ---
    Private Sub dgvAntrian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAntrian.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            NoRegAktif = dgvAntrian.Rows(e.RowIndex).Cells("no_registrasi").Value.ToString()

            ' Isi Identitas Otomatis
            txtnoreg.Text = NoRegAktif
            txtnorm.Text = dgvAntrian.Rows(e.RowIndex).Cells("no_rm").Value.ToString()
            txtdokter.Text = dgvAntrian.Rows(e.RowIndex).Cells("nama_dokter").Value.ToString()

            ' Load Obat & Set Default Tindakan
            Call HitungBiayaObat()

            ' Reset Tindakan & Beri Template Awal
            dgvTindakan.Rows.Clear()
            ' Kita kasih default biar Kasir gak ngetik dari nol, tapi bisa diedit/hapus
            dgvTindakan.Rows.Add("Jasa Dokter Umum", "50000", "1", "50000")
            dgvTindakan.Rows.Add("Biaya Admin", "10000", "1", "10000")

            Call HitungGrandTotal()

        Catch ex As Exception
            MsgBox("Error Pilih Pasien: " & ex.Message)
        End Try
    End Sub

    ' --- 5. LOGIKA EDIT MANUAL (INTI PERUBAHAN) ---
    ' Event ini berjalan SETIAP KALI Kasir selesai mengetik di tabel tindakan
    Private Sub dgvTindakan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTindakan.CellEndEdit
        Try
            ' Ambil baris yang sedang diedit
            Dim row As DataGridViewRow = dgvTindakan.Rows(e.RowIndex)

            ' Ambil Nilai Biaya & Qty yang baru diketik
            ' Val() mengubah teks jadi angka (aman dari error jika kosong)
            Dim Biaya As Decimal = Val(row.Cells("biaya").Value)
            Dim Qty As Integer = Val(row.Cells("qty").Value)

            ' Hitung Subtotal Baru
            Dim Subtotal As Decimal = Biaya * Qty

            ' Update kolom Subtotal
            row.Cells("subtotal").Value = Subtotal

            ' Update Total Tagihan Keseluruhan
            Call HitungGrandTotal()

        Catch ex As Exception
            ' Abaikan error kecil saat ngetik
        End Try
    End Sub

    ' --- 6. HITUNG GRAND TOTAL ---
    Sub HitungGrandTotal()
        GrandTotal = 0

        ' Jumlahkan Tabel Tindakan
        For Each row As DataGridViewRow In dgvTindakan.Rows
            ' Cek biar baris kosong gak dihitung
            If row.Cells("subtotal").Value IsNot Nothing Then
                GrandTotal += CDec(row.Cells("subtotal").Value)
            End If
        Next

        ' Jumlahkan Tabel Obat
        For Each row As DataGridViewRow In dgvObat.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                GrandTotal += CDec(row.Cells("subtotal").Value)
            End If
        Next

        ' Tampilkan format Rupiah (tanpa Rp biar rapi di textbox)
        txtTotalTagihan.Text = FormatNumber(GrandTotal, 0)
    End Sub

    ' --- 7. LOAD OBAT (TETAP SAMA) ---
    Sub HitungBiayaObat()
        dgvObat.Rows.Clear()
        Try
            Call BukaKoneksi()
            Dim query As String = "SELECT o.nama_obat, o.harga_satuan, fd.jumlah, fd.subtotal " &
                                  "FROM tbl_farmasi f " &
                                  "JOIN tbl_farmasi_detail fd ON f.id_farmasi = fd.id_resep " &
                                  "JOIN tbl_obat o ON fd.id_obat = o.id_obat " &
                                  "WHERE f.no_registrasi = '" & NoRegAktif & "'"

            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader
            While Rd.Read
                dgvObat.Rows.Add(Rd("nama_obat"), FormatNumber(Rd("harga_satuan"), 0), Rd("jumlah"), FormatNumber(Rd("subtotal"), 0))
            End While
            Rd.Close()
        Catch ex As Exception
            MsgBox("Gagal Load Obat: " & ex.Message)
        End Try
    End Sub

    ' --- 8. PROSES BAYAR ---
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If NoRegAktif = "" Then Exit Sub

        Dim UangBayar As Decimal = Val(txtUangBayar.Text)

        If UangBayar < GrandTotal Then
            MsgBox("Uang Kurang! Kurang: " & FormatNumber(GrandTotal - UangBayar, 0), MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim Kembalian As Decimal = UangBayar - GrandTotal

        If MsgBox("LUNAS? Kembalian: " & FormatNumber(Kembalian, 0), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call BukaKoneksi()
                ' Update Lunas di Janji Temu
                Dim cmd As New MySqlCommand("UPDATE tbl_janji_temu SET status='Lunas' WHERE no_registrasi='" & NoRegAktif & "'", Conn)
                cmd.ExecuteNonQuery()

                ' Update Lunas di Farmasi
                Dim cmd2 As New MySqlCommand("UPDATE tbl_farmasi SET status_bayar='Lunas' WHERE no_registrasi='" & NoRegAktif & "'", Conn)
                cmd2.ExecuteNonQuery()

                ' --- SIMPAN DETAIL TINDAKAN KE DATABASE (OPSIONAL/NEXT STEP) ---
                ' Di sini bisa ditambahkan kode INSERT ke tbl_pembayaran_detail jika ingin menyimpan history harga yang diedit manual tadi.

                MsgBox("Transaksi Selesai.", MsgBoxStyle.Information)

                ' Reset Form
                dgvTindakan.Rows.Clear()
                dgvObat.Rows.Clear()
                txtTotalTagihan.Text = "0"
                txtUangBayar.Text = "0"
                txtNoRM.Clear()
                txtdokter.Clear()
                NoRegAktif = ""

                Call LoadAntrianKasir()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' Fitur Hapus Baris Tindakan dengan Tombol Delete Keyboard
    Private Sub dgvTindakan_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTindakan.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvTindakan.CurrentRow IsNot Nothing Then
                dgvTindakan.Rows.Remove(dgvTindakan.CurrentRow)
                Call HitungGrandTotal() ' Hitung ulang setelah hapus
            End If
        End If
    End Sub

End Class