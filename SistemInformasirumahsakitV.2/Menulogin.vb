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

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If lblErrorMessage.Visible Then
            lblErrorMessage.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If lblErrorMessage.Visible Then
            lblErrorMessage.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblErrorMessage.Visible = False

        ' 2. Validasi Input Kosong (Permintaan Anda)
        If String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Anda harus mengisi Username dan Kata Sandi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Berhenti eksekusi
        End If

        ' 3. Proses Login ke Database
        ' Pastikan Anda punya Modul KoneksiDB.vb
        Using conn As MySqlConnection = KoneksiDB.GetConnection()
            If conn Is Nothing Then Return ' Gagal dapat koneksi (pesan error dari KoneksiDB)

            Try
                ' --- PENTING: GANTI INI SESUAI TABEL ANDA ---
                Dim query As String = "SELECT COUNT(*) FROM tbl_admin WHERE username = @user AND password = @pass"
                ' ---------------------------------------------

                Using cmd As New MySqlCommand(query, conn)
                    ' Anti SQL Injection
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text)


                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If result > 0 Then
                        ' --- LOGIN BERHASIL ---
                        Me.Hide()
                        ' Asumsi Form Dashboard Anda bernama Form1
                        Dim frmDashboard As New frmDashboard()
                        frmDashboard.Show()

                    Else
                        ' --- LOGIN GAGAL (Permintaan Anda) ---
                        ' Tampilkan pesan error merah di label
                        lblErrorMessage.Text = "Invalid username or password"
                        lblErrorMessage.Visible = True
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error Database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
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
            For i As Integer = 0 To Bytes.Length - 1
                builder.Append(Bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

End Class