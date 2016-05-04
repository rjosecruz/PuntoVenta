Imports MySql.Data.MySqlClient
Public Class repocliente
    Public Function findById(ByVal _id As Integer) As cliente

        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xcliente As cliente = New cliente
        Try
            sql = "select * from cliente where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xcliente.Id = datos(0)
                    xcliente.Rtn = datos(1)
                    xcliente.Nombre = datos(2)
                    xcliente.Direccion = datos(3)
                    xcliente.Idzona = datos(4)
                    xcliente.Idvendedor = datos(5)
                    xcliente.Saldo = datos(6)
                    xcliente.Limitecredito = datos(7)
                    xcliente.Estado = datos(8)
                    xcliente.Diascredito = datos(9)
                    xcliente.Mail = datos(10)
                    xcliente.Telefono = datos(11)
                    xcliente.Movil = datos(12)
                    xcliente.Contacto = datos(13)
                    xcliente.Latitud = datos(14)
                    xcliente.Longitud = datos(15)
                End While
            End If
            comando.Dispose()
            datos.Close()
            xcliente.getExtras()
        Catch ex As Exception
            Return xcliente
        End Try
        Return xcliente

    End Function

    Public Function insert(ByVal xcliente As cliente) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "INSERT INTO cliente VALUES
                                                (default,
                                                ?_rtn,
                                                ?_nombre_cliente,
                                                ?_direccion,
                                                ?_zona_ID,
                                                ?_vendedor_ID,
                                                ?_saldo,
                                                ?_limite_credito,
                                                ?_estado,
                                                ?_dias_credito,
                                                ?_mail,
                                                ?_telefono,
                                                ?_movil,
                                                ?_contacto,
                                                ?_latitud,
                                                ?_longitud)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?_rtn", xcliente.Rtn)
            comando.Parameters.AddWithValue("?_nombre_cliente", xcliente.Nombre)
            comando.Parameters.AddWithValue("?_direccion", xcliente.Direccion)
            comando.Parameters.AddWithValue("?_zona_ID", xcliente.Idzona)
            comando.Parameters.AddWithValue("?_vendedor_ID", xcliente.Idvendedor)
            comando.Parameters.AddWithValue("?_saldo", xcliente.Saldo)
            comando.Parameters.AddWithValue("?_limite_credito", xcliente.Limitecredito)
            comando.Parameters.AddWithValue("?_estado", xcliente.Estado)
            comando.Parameters.AddWithValue("?_dias_credito", xcliente.Diascredito)
            comando.Parameters.AddWithValue("?_mail", xcliente.Mail)
            comando.Parameters.AddWithValue("?_telefono", xcliente.Telefono)
            comando.Parameters.AddWithValue("?_movil", xcliente.Movil)
            comando.Parameters.AddWithValue("?_contacto", xcliente.Contacto)
            comando.Parameters.AddWithValue("?_latitud", xcliente.Latitud)
            comando.Parameters.AddWithValue("?_longitud", xcliente.Longitud)
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
            sql = "select * from cliente"
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
            sql = "select * from cliente where nombre_cliente like '%" + filtro + "%' or contacto like '%" + filtro + "%'"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function

    Public Function update(ByVal xcliente As cliente) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Try
            sqlinsert = "UPDATE cliente
                                    SET
                                    rtn = ?_rtn,
                                    nombre_cliente = ?_nombre_cliente,
                                    direccion = ?_direccion,
                                    zona__ID = ?_zona_ID,
                                    vendedor__ID = ?_vendedor_ID,
                                    saldo = ?_saldo,
                                    limite_credito = ?_limite_credito,
                                    estado = ?_estado,
                                    dias_credito = ?_dias_credito,
                                    mail = ?_mail,
                                    telefono = ?_telefono,
                                    movil = ?_movil,
                                    contacto = ?_contacto,
                                    latitud = ?_latitud,
                                    longitud = ?_longitud
                                    WHERE _ID = ?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?_id", xcliente.Id)
            comando.Parameters.AddWithValue("?_rtn", xcliente.Rtn)
            comando.Parameters.AddWithValue("?_nombre_cliente", xcliente.Nombre)
            comando.Parameters.AddWithValue("?_direccion", xcliente.Direccion)
            comando.Parameters.AddWithValue("?_zona_ID", xcliente.Idzona)
            comando.Parameters.AddWithValue("?_vendedor_ID", xcliente.Idvendedor)
            comando.Parameters.AddWithValue("?_saldo", xcliente.Saldo)
            comando.Parameters.AddWithValue("?_limite_credito", xcliente.Limitecredito)
            comando.Parameters.AddWithValue("?_estado", xcliente.Estado)
            comando.Parameters.AddWithValue("?_dias_credito", xcliente.Diascredito)
            comando.Parameters.AddWithValue("?_mail", xcliente.Mail)
            comando.Parameters.AddWithValue("?_telefono", xcliente.Telefono)
            comando.Parameters.AddWithValue("?_movil", xcliente.Movil)
            comando.Parameters.AddWithValue("?_contacto", xcliente.Contacto)
            comando.Parameters.AddWithValue("?_latitud", xcliente.Latitud)
            comando.Parameters.AddWithValue("?_longitud", xcliente.Longitud)
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
            sqldelete = "delete from cliente where _ID=?_id"
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
