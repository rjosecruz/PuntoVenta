Imports MySql.Data.MySqlClient
Public Class repoVendedor
    Public Function findById(ByVal _id As Integer) As vendedor
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xvendedor As vendedor = New vendedor
        Try
            sql = "select * from vendedor where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xvendedor.Id = datos(0)
                    xvendedor.Nombre = datos(1)
                    xvendedor.Direccion = datos(2)
                    xvendedor.Telefono = datos(3)
                    xvendedor.Estado = datos(4)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xvendedor
        End Try
        Return xvendedor
    End Function

    Public Function insert(ByVal mivendedor As vendedor) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "insert into vendedor values(default,?nombre,?direccion,?telefono,?estado)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?nombre", mivendedor.Nombre)
            comando.Parameters.AddWithValue("?direccion", mivendedor.Direccion)
            comando.Parameters.AddWithValue("?telefono", mivendedor.Telefono)
            comando.Parameters.AddWithValue("?estado", mivendedor.Estado)
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
            sql = "select * from vendedor"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function

    Public Function update(ByVal xvendedor As vendedor) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "update vendedor set nombre=?nombre,direccion=?direccion,telefono=?telefono,estado=?estado where _ID=?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?nombre", xvendedor.Nombre)
            comando.Parameters.AddWithValue("?direccion", xvendedor.Direccion)
            comando.Parameters.AddWithValue("?telefono", xvendedor.Telefono)
            comando.Parameters.AddWithValue("?estado", xvendedor.Estado)
            comando.Parameters.AddWithValue("?_id", xvendedor.Id)

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
            sqldelete = "delete from vendedor where _ID=?_id"
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
