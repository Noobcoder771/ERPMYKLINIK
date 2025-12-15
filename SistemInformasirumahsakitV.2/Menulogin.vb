Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities
Public Class Menulogin

    Private Sub CenterLoginPanel()
        mainPanel.Left = (Me.ClientSize.Width - mainPanel.Width) / 2
        mainPanel.Top = (Me.ClientSize.Height - mainPanel.Height) / 2
    End Sub

    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterLoginPanel()
    End Sub

    Private Sub MenuLogin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLoginPanel()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        If lblErrorMessage.Visible Then
            lblErrorMessage.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If lblErrorMessage.Visible Then
            lblErrorMessage.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call BukaKoneksi() ' Memanggil koneksi dari Module1

            ' Cek Username & Password
            Dim query As String = "SELECT * FROM tbl_user WHERE username = @user AND password = @pass"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@user", txtUser.Text)
            Cmd.Parameters.AddWithValue("@pass", txtPass.Text)

            Rd = Cmd.ExecuteReader

            If Rd.Read() Then
                ' --- LOGIN SUKSES ---

                ' 1. Simpan Identitas ke Module1 (Variabel Global)
                ModulKoneksi.UserName = Rd("nama_lengkap").ToString()
                ModulKoneksi.UserRole = Rd("role").ToString() ' Penting: Ambil Admin/Dokter/Staff

                MsgBox("Login Berhasil! Selamat Datang, " & ModulKoneksi.UserRole, MsgBoxStyle.Information)

                ' 2. Buka Dashboard
                Dim MenuUtama As New frmDashboard ' Asumsikan Form1 adalah dashboard
                MenuUtama.Show()

                ' 3. Sembunyikan Form Login
                Me.Hide()
            Else
                MsgBox("Username atau Password Salah!", MsgBoxStyle.Critical)
            End If

            Rd.Close()

        Catch ex As Exception
            MsgBox("Gagal Login: " & ex.Message)
        Finally
            Call TutupKoneksi()
        End Try
    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblErrorMessage_Click(sender As Object, e As EventArgs) Handles lblaja.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Function ComputeSha26Hash(plainText As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

End Class