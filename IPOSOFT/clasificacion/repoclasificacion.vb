Imports MySql.Data.MySqlClient
Public Class repoclasificacion
    Public Function findById(ByVal _id As Integer) As clasificacion
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xclasificacion As clasificacion = New clasificacion
        Try
            sql = "select * from clasificacion where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xclasificacion.Id = datos(0)
                    xclasificacion.Clasificacion = datos(1)
                    xclasificacion.Estado = datos(2)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xclasificacion
        End Try
        Return xclasificacion
    End Function
    Public Function insert(ByVal miclasificacion As clasificacion) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "insert into clasificacion values(default,?clasificacion,?estado)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?clasificacion", miclasificacion.Clasificacion)
            comando.Parameters.AddWithValue("?estado", miclasificacion.Estado)
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
            sql = "select * from clasificacion"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function query(ByVal filtro As String) As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Try
            sql = "select * from clasificacion where descripcion like '%" + filtro + "%'"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function update(ByVal xclasifiacion As clasificacion) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "update clasificacion set descripcion=?clasificacion,estado=?estado where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?clasificacion", xclasifiacion.Clasificacion)
            comando.Parameters.AddWithValue("?estado", xclasifiacion.Estado)
            comando.Parameters.AddWithValue("?_id", xclasifiacion.Id)
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
            sqldelete = "delete from clasificacion where _ID=?_id"
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
