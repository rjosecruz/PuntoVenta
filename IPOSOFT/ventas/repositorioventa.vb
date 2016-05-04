Imports MySql.Data.MySqlClient
Public Class repositorioventa
    Public Function FindById(ByVal numero As Integer) As MySqlDataReader

        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim consulta As String
        consulta = "select * from v_factura where _id=" & numero
        Try
            comando = New MySqlCommand(consulta, db)
            datos = comando.ExecuteReader

        Catch ex As Exception

        End Try
        Return datos

    End Function
    Public Function Query() As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim consulta As String
        consulta = "select distinct _ID,fecha_factura,nombre_cliente,total,estado_pago from v_factura"
        Try
            comando = New MySqlCommand(consulta, db)
            datos = comando.ExecuteReader

        Catch ex As Exception

        End Try
        Return datos
    End Function
    Public Function Query(ByVal filtro As String) As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim consulta As String
        consulta = "select distinct _ID,fecha_factura,nombre_cliente,total,estado_pago from v_factura where nombre_cliente like '%" + filtro + "%'"
        Try
            comando = New MySqlCommand(consulta, db)
            datos = comando.ExecuteReader

        Catch ex As Exception

        End Try
        Return datos
    End Function
    Public Function Insert(ByVal datos As factura) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Dim sqlinsertdetalle As String
        Dim id As Integer
        Dim Transac As MySqlTransaction
        Try
            db2.Open()
            Transac = db2.BeginTransaction
            sqlinsert = "INSERT INTO factura(_ID,numero,fecha_factura,tipo_fatura,dias_credito,cliente__ID,vendedor__ID,subtotal,impuesto,total,saldo,CAI,estado_pago__ID,estado_factura__ID)
VALUES(default,?numero,?fecha_factura,?tipo_fatura,?dias_credito,?cliente__ID,?vendedor__ID,?subtotal,?impuesto,?total,?saldo,?CAI,?estado_pago__ID,?estado_factura__ID)"
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert

            comando.Parameters.AddWithValue("?numero", 0)
            comando.Parameters.AddWithValue("?fecha_factura", datos.xencabezadofactura.Fecha)
            comando.Parameters.AddWithValue("?tipo_fatura", datos.xencabezadofactura.TipoFactura)
            comando.Parameters.AddWithValue("?dias_credito", datos.xencabezadofactura.DiasCredito)
            comando.Parameters.AddWithValue("?cliente__ID", datos.xencabezadofactura.IdCliente)
            comando.Parameters.AddWithValue("?vendedor__ID", datos.xencabezadofactura.Vendedor)
            comando.Parameters.AddWithValue("?subtotal", datos.xencabezadofactura.Subtotal)
            comando.Parameters.AddWithValue("?impuesto", datos.xencabezadofactura.Impuesto)
            comando.Parameters.AddWithValue("?total", datos.xencabezadofactura.Total)
            comando.Parameters.AddWithValue("?saldo", datos.xencabezadofactura.Total)
            comando.Parameters.AddWithValue("?CAI", datos.xencabezadofactura.CAI)
            comando.Parameters.AddWithValue("?estado_pago__ID", datos.xencabezadofactura.EstadoPago)
            comando.Parameters.AddWithValue("?estado_factura__ID", datos.xencabezadofactura.EstadoFactura)

            comando.ExecuteNonQuery()

            id = comando.LastInsertedId
            comando.Parameters.RemoveAt("?numero")
            comando.Parameters.RemoveAt("?fecha_factura")
            comando.Parameters.RemoveAt("?tipo_fatura")
            comando.Parameters.RemoveAt("?dias_credito")
            comando.Parameters.RemoveAt("?cliente__ID")
            comando.Parameters.RemoveAt("?vendedor__ID")
            comando.Parameters.RemoveAt("?subtotal")
            comando.Parameters.RemoveAt("?impuesto")
            comando.Parameters.RemoveAt("?total")
            comando.Parameters.RemoveAt("?saldo")
            comando.Parameters.RemoveAt("?CAI")
            comando.Parameters.RemoveAt("?estado_pago__ID")
            comando.Parameters.RemoveAt("?estado_factura__ID")

            sqlinsertdetalle = "INSERT INTO factura_detalle(_ID,factura__ID,producto__ID,cantidad,precio,subtotal_linea,impuesto_linea,total_linea,impuesto__ID)
VALUES(default,?factura_ID,?producto__ID,?cantidad,?precio,?subtotal_linea,?impuesto_linea,?total_linea,?impuesto__ID)"
            comando.CommandText = sqlinsertdetalle

            For Each miarticulo In datos.xdetalleFactura
                comando.Parameters.AddWithValue("?factura_ID", id)
                comando.Parameters.AddWithValue("?producto__ID", miarticulo.IdProducto)
                comando.Parameters.AddWithValue("?cantidad", miarticulo.Cantidad)
                comando.Parameters.AddWithValue("?precio", miarticulo.Precio)
                comando.Parameters.AddWithValue("?subtotal_linea", miarticulo.Subtotal)
                comando.Parameters.AddWithValue("?impuesto_linea", miarticulo.Impuesto)
                comando.Parameters.AddWithValue("?total_linea", miarticulo.Total)
                comando.Parameters.AddWithValue("?impuesto__ID", miarticulo.IdImpuesto)
                comando.ExecuteNonQuery()
                comando.Parameters.Clear()
            Next



            Dim sqlexistencia As String
            sqlexistencia = "UPDATE articulo_almancen SET existencia =existencia - ?existencia where producto__ID = ?id_producto AND almacen__ID = ?id_almacen"
            comando.CommandText = sqlexistencia
            For Each miarticulo In datos.xdetalleFactura
                comando.Parameters.AddWithValue("?existencia", miarticulo.Cantidad)
                comando.Parameters.AddWithValue("?id_producto", miarticulo.IdProducto)
                comando.Parameters.AddWithValue("?id_almacen", 2)
                comando.ExecuteNonQuery()
                comando.Parameters.Clear()
            Next

            Transac.Commit()
            db2.Close()
        Catch ex As Exception
            Transac.Rollback()
            db2.Close()
        End Try
        Return 0
    End Function

End Class
