Imports MySql.Data.MySqlClient
Module inicio
    Dim cadena As MySqlConnectionStringBuilder
    Public menu As frmmenu
    Public db As MySqlConnection
    Public db2 As MySqlConnection
    Public Sub main()
        cadena = New MySqlConnectionStringBuilder
        cadena.Server = "127.0.0.1"
        cadena.UserID = "root"
        cadena.Password = "TOSHIBA"
        cadena.Database = "iposoft"
        db = New MySqlConnection(cadena.ToString)
        db2 = New MySqlConnection(cadena.ToString)
        Try
            db.Open()
            Application.Run(New frmmenu)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
