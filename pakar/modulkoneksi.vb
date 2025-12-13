Imports Microsoft.Data.SqlClient

Module modulkoneksi
    ' Connection string (sudah disesuaikan agar tidak error SSL)
    Public connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\denar\source\repos\Fidel1710\Pakarskibidi\pakar\pakar.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True"

    Public Function getConnection() As SqlConnection
        Dim conn As New SqlConnection(connStr)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Koneksi Database Gagal: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Module