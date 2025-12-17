Imports MySql.Data.MySqlClient

Public Class pilihobatkasir

    Public HasilObat As String = ""

    Dim ListSemuaObat As New List(Of String)

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MuatDataObat()
        txtSearch.Focus()
    End Sub

    Sub MuatDataObat()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim cmd As New MySqlCommand("SELECT nama_obat FROM tbl_obat WHERE stok > 0 ORDER BY nama_obat ASC", Conn)
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            lstObat.Items.Clear()
            ListSemuaObat.Clear()

            While rd.Read
                Dim nama As String = rd("nama_obat").ToString()
                lstObat.Items.Add(nama)
                ListSemuaObat.Add(nama)
            End While
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Error Load Obat: " & ex.Message)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lstObat.Items.Clear()
        Dim keyword As String = txtSearch.Text.ToLower()

        For Each obat In ListSemuaObat
            If obat.ToLower().Contains(keyword) Then
                lstObat.Items.Add(obat)
            End If
        Next
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lstObat.Items.Count > 0 Then
                lstObat.SelectedIndex = 0
                PilihDanTutup()
            End If
        ElseIf e.KeyCode = Keys.Down Then
            lstObat.Focus()
        End If
    End Sub

    Private Sub lstObat_KeyDown(sender As Object, e As KeyEventArgs) Handles lstObat.KeyDown
        If e.KeyCode = Keys.Enter Then
            PilihDanTutup()
        End If
    End Sub

    Private Sub lstObat_DoubleClick(sender As Object, e As EventArgs) Handles lstObat.DoubleClick
        PilihDanTutup()
    End Sub

    Sub PilihDanTutup()
        If lstObat.SelectedIndex <> -1 Then
            HasilObat = "R/ " & lstObat.SelectedItem.ToString() & " No. X" & vbCrLf & "   S 3 dd 1" & vbCrLf
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub lstObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObat.SelectedIndexChanged

    End Sub
End Class