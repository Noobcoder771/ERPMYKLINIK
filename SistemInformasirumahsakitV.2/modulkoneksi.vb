Imports MySql.Data.MySqlClient
Imports System.Data ' Penting agar kata "ConnectionState" tidak error

Module ModulKoneksi
    ' Info Database (Sesuai punya kamu: sirs_db)
    Public strKoneksi As String = "Server=localhost;User Id=root;Password=;Database=sirs"

    ' Variabel Global (Untuk Form Pendaftaran, dll)
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Rd As MySqlDataReader

    ' 1. SUB UNTUK FORM PENDAFTARAN (Gaya Global)
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

    ' 2. FUNGSI UNTUK FORM LOGIN (Ini yang dicari error GetConnection tadi)
    ' Fungsi ini mengembalikan koneksi baru khusus untuk perintah "Using"
    Public Function GetConnection() As MySqlConnection
        Dim connTemp As New MySqlConnection(strKoneksi)
        connTemp.Open()
        Return connTemp
    End Function

End Module