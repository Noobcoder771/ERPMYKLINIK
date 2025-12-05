Imports System.Windows.Forms
Public Class ucPendaftaranPasien
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ucPendaftaranPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ucPendaftaranPasien_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Pastikan CentralPanel ada
        If CentralPanel IsNot Nothing Then ' <-- Ganti CenterPanel ke CentralPanel

            ' Hitung posisi X 
            Dim x As Integer = (Me.Width - CentralPanel.Width) / 2 ' <-- Ganti CenterPanel ke CentralPanel

            ' Hitung posisi Y
            Dim y As Integer = 50

    End Sub
    Private Sub CentralPanel_Paint(sender As Object, e As PaintEventArgs) Handles CentralPanel.Paint

    End Sub
End Class
