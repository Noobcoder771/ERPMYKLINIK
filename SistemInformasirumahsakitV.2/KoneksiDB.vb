Imports MySql.Data.MySqlClient

Module KoneksiDB
    Private ReadOnly connString As String = "Server=localhost;Database=sirs_db;User=root;Password=;"
    Public Function GetConnection() As MySqlConnection
        Try
            Return New MySqlConnection(connString)
        Catch ex As Exception
            MessageBox.Show("Gagal membuat koneksi ke database: " & vbCrLf & ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Module
