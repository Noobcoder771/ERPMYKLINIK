Imports MySql.Data.MySqlClient

Module ModulKoneksi
    ' Ganti info database di bawah ini sesuai settingan XAMPP kamu
    Public strKoneksi As String = "Server=localhost;User Id=root;Password=;Database=sirs_db"

    ' PENTING: Gunakan kata 'Public' agar bisa dibaca oleh Form lain
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Rd As MySqlDataReader

    ' Sub ini harus PUBLIC agar bisa dipanggil dari Form Pendaftaran
    Public Sub BukaKoneksi()
        Try
            If Conn Is Nothing OrElse Conn.State = ConnectionState.Closed Then
                Conn = New MySqlConnection(strKoneksi)
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal: " & ex.Message)
        End Try
    End Sub

    Public Sub TutupKoneksi()
        If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub
End Module