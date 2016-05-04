Imports MySql.Data.MySqlClient
Public Class connection
    Public db As MySqlConnection
    Dim cadenax As MySqlConnectionStringBuilder
    Function getConnection() As MySqlConnection
        Try
            cadenax = New MySqlConnectionStringBuilder
            cadenax.Server = "localhost"
            cadenax.Database = "inventario"
            cadenax.UserID = "sgi"
            cadenax.Password = "TOSHIBA"
            db = New MySqlConnection(cadenax.ToString)
            db.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return db
    End Function
End Class
