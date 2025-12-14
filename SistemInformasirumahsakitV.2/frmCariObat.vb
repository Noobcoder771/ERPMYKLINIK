Imports MySql.Data.MySqlClient

Public Class frmCariObat

    ' Variabel untuk mengirim hasil pilihan kembali ke Dokter
    Public HasilObat As String = ""

    ' Data sementara di memori
    Dim ListSemuaObat As New List(Of String)

    Private Sub frmCariObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MuatDataObat()
        txtSearch.Focus() ' Langsung siap ketik
    End Sub

    Sub MuatDataObat()
        Try
            ' Pastikan koneksi global (Conn) bisa diakses. 
            ' Jika error, ganti Conn dengan string koneksi lengkap atau Module1.Conn
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim cmd As New MySqlCommand("SELECT nama_obat FROM tbl_obat WHERE stok > 0 ORDER BY nama_obat ASC", Conn)
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            lstObat.Items.Clear()
            ListSemuaObat.Clear()

            While rd.Read
                Dim nama As String = rd("nama_obat").ToString()
                lstObat.Items.Add(nama)
                ListSemuaObat.Add(nama) ' Simpan di memori untuk filtering cepat
            End While
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Error Load Obat: " & ex.Message)
        End Try
    End Sub

    ' FITUR PENCARIAN CEPAT (Tanpa query ulang database)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lstObat.Items.Clear()
        Dim keyword As String = txtSearch.Text.ToLower()

        For Each obat In ListSemuaObat
            If obat.ToLower().Contains(keyword) Then
                lstObat.Items.Add(obat)
            End If
        Next
    End Sub

    ' PILIH OBAT DENGAN ENTER
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Jika ada yang cocok di list, ambil yang paling atas
            If lstObat.Items.Count > 0 Then
                lstObat.SelectedIndex = 0
                PilihDanTutup()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            lstObat.Focus() ' Pindah fokus ke list bawah
        End If
    End Sub

    ' PILIH OBAT DENGAN ENTER DI LISTBOX
    Private Sub lstObat_KeyDown(sender As Object, e As KeyEventArgs) Handles lstObat.KeyDown
        If e.KeyCode = Keys.Enter Then
            PilihDanTutup()
        End If
    End Sub

    ' PILIH OBAT DENGAN DOUBLE CLICK
    Private Sub lstObat_DoubleClick(sender As Object, e As EventArgs) Handles lstObat.DoubleClick
        PilihDanTutup()
    End Sub

    Sub PilihDanTutup()
        If lstObat.SelectedIndex <> -1 Then
            ' Format Resep Standar
            HasilObat = "R/ " & lstObat.SelectedItem.ToString() & " No. X" & vbCrLf & "   S 3 dd 1" & vbCrLf
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class