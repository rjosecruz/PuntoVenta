Imports MySql.Data.MySqlClient
Public Class repositorioHelpers
    Public Function FindAllTipoDocumentos() As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String

        Try
            sql = "select _ID, tipo from tipo_documento"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
        Catch ex As Exception

        End Try
        Return datos
    End Function

End Class
