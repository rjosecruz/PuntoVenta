Imports MySql.Data.MySqlClient
Public Class repoimpuesto
    Public Function findById(ByVal _id As Integer) As impuesto
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim ximpuesto As impuesto = New impuesto
        Try
            sql = "select * from impuesto where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    ximpuesto.Id = datos(0)
                    ximpuesto.Impuesto = datos(1)
                    ximpuesto.Porcentaje = datos(2)
                    ximpuesto.Estado = datos(3)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return ximpuesto
        End Try
        Return ximpuesto
    End Function
    Public Function insert(ByVal miimpuesto As impuesto) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "insert into impuesto values(default,?impuesto,?porcentaje,?estado)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?impuesto", miimpuesto.Impuesto)
            comando.Parameters.AddWithValue("?porcentaje", miimpuesto.Porcentaje)
            comando.Parameters.AddWithValue("?estado", miimpuesto.Estado)
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
            sql = "select * from impuesto"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function update(ByVal ximpuesto As impuesto) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "update impuesto set descripcion=?impuesto,porcentaje=?porcentaje,estado=?estado where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?impuesto", ximpuesto.Impuesto)
            comando.Parameters.AddWithValue("?porcentaje", ximpuesto.Porcentaje)
            comando.Parameters.AddWithValue("?estado", ximpuesto.Estado)
            comando.Parameters.AddWithValue("?_id", ximpuesto.Id)
            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function

    Public Function delete(ByVal xcodigo As Integer) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqldelete As String
        Try
            sqldelete = "delete from impuesto where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqldelete
            comando.Parameters.AddWithValue("?_id", xcodigo)
            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function
End Class
