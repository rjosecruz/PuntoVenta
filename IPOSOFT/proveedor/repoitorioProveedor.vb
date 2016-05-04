Imports MySql.Data.MySqlClient
Public Class repoitorioProveedor
    Public Function findById(ByVal _id As Integer) As proveedor
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xproveedor As proveedor = New proveedor
        Try
            sql = "select * from proveedor where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xproveedor.Id = datos(0)
                    xproveedor.Codigo = datos(1)
                    xproveedor.Nombre = datos(2)
                    xproveedor.Representante = datos(3)
                    xproveedor.Direccion = datos(4)
                    xproveedor.Telefono = datos(5)
                    xproveedor.Mail = datos(6)
                    xproveedor.Estado = datos(7)
                    xproveedor.Pais = datos(8)
                    xproveedor.Saldo = datos(9)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xproveedor
        End Try
        Return xproveedor
    End Function
    Public Function insert(ByVal xproveedor As proveedor) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "insert into proveedor VALUES(default,?codigo,?nombre,?representante,
                                                          ?direccion,
                                                    ?telefono,
                                                    ?email,
                                                    ?estado,
                                                    ?pais,
                                                    ?saldo)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?codigo", xproveedor.Codigo)
            comando.Parameters.AddWithValue("?nombre", xproveedor.Nombre)
            comando.Parameters.AddWithValue("?representante", xproveedor.Representante)
            comando.Parameters.AddWithValue("?direccion", xproveedor.Direccion)
            comando.Parameters.AddWithValue("?telefono", xproveedor.Telefono)
            comando.Parameters.AddWithValue("?email", xproveedor.Mail)
            comando.Parameters.AddWithValue("?estado", xproveedor.Estado)
            comando.Parameters.AddWithValue("?pais", xproveedor.Pais)
            comando.Parameters.AddWithValue("?saldo", xproveedor.Saldo)
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
            sql = "select * from proveedor"
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
            sql = "select * from proveedor where nombre like '%" + filtro + "%' or representante like '%" + filtro + "%'"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function update(ByVal xproveedor As proveedor) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "UPDATE proveedor SET codigo = ?codigo, nombre = ?nombre, representante = ?representante,
                                             direccion = ?direccion, telefono = ?telefono, email = ?email,
                                            estado = ?estado, pais = ?pais, saldo = ?saldo
                                            WHERE _ID = ?id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?codigo", xproveedor.Codigo)
            comando.Parameters.AddWithValue("?nombre", xproveedor.Nombre)
            comando.Parameters.AddWithValue("?representante", xproveedor.Representante)
            comando.Parameters.AddWithValue("?direccion", xproveedor.Direccion)
            comando.Parameters.AddWithValue("?telefono", xproveedor.Telefono)
            comando.Parameters.AddWithValue("?email", xproveedor.Mail)
            comando.Parameters.AddWithValue("?estado", xproveedor.Estado)
            comando.Parameters.AddWithValue("?pais", xproveedor.Pais)
            comando.Parameters.AddWithValue("?saldo", xproveedor.Saldo)
            comando.Parameters.AddWithValue("?id", xproveedor.Id)
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
            sqldelete = "delete from proveedor where _ID=?_id"
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
