Imports MySql.Data.MySqlClient
Public Class repositorioAlmacen
    Public datos As MySqlDataReader
    Public Function findById(ByVal _id As Integer) As almacen

        Dim comando As MySqlCommand
        Dim sql As String
        Dim xalmacen As almacen = New almacen
        Try
            sql = "select * from almacen where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xalmacen.Id = datos(0)
                    xalmacen.Almacen = datos(1)
                    xalmacen.Direccion = datos(2)
                    xalmacen.Estado = datos(3)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xalmacen
        End Try
        Return xalmacen
    End Function
    Public Function insert(ByVal mialmacen As almacen) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "insert into almacen values(default,?almacen,?direccion,?estado)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?almacen", mialmacen.Almacen)
            comando.Parameters.AddWithValue("?direccion", mialmacen.Direccion)
            comando.Parameters.AddWithValue("?estado", mialmacen.Estado)
            comando.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            Return 1
        End Try
        Return 0
    End Function
    Public Function query() As MySqlDataReader

        Dim comando As MySqlCommand
        Dim sql As String
        Try
            sql = "select * from almacen"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function query(ByVal filtro As String) As MySqlDataReader

        Dim comando As MySqlCommand
        Dim sql As String
        Try
            sql = "select * from almacen where nombre like '%" + filtro + "%'"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function update(ByVal xalmacen As almacen) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "update almacen set nombre=?almacen,direccion=?direccion,estado=?estado where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?almacen", xalmacen.Almacen)
            comando.Parameters.AddWithValue("?direccion", xalmacen.Direccion)
            comando.Parameters.AddWithValue("?estado", xalmacen.Estado)
            comando.Parameters.AddWithValue("?_id", xalmacen.Id)
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
            sqldelete = "delete from almacen where _ID=?_id"
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
