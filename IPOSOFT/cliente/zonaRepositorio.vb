Imports MySql.Data.MySqlClient
Public Class zonaRepositorio
    Public Function findById(ByVal _id As Integer) As Zona

        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xzona As Zona = New Zona
        Try
            sql = "select * from zona where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xzona.ID = datos(0)
                    xzona.zona = datos(1)
                    xzona.estado = datos(2)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xzona
        End Try
        Return xzona

    End Function

    Public Function insert(ByVal mizona As Zona) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "insert into zona values(default,?zona,default)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?zona", mizona.zona)
            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function

    Public Function query() As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Try
            sql = "select * from zona"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function

    Public Function update(ByVal xzona As Zona) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "update zona set nombre=?nombre,estado=?estado where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?nombre", xzona.zona)
            comando.Parameters.AddWithValue("?_id", xzona.ID)
            comando.Parameters.AddWithValue("?estado", xzona.estado)
            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function

    Public Function delete(ByVal xzona As Integer) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqldelete As String

        Try
            sqldelete = "delete from zona where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqldelete

            comando.Parameters.AddWithValue("?_id", xzona)

            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function

End Class
