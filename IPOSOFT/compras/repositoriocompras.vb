Imports MySql.Data.MySqlClient
Public Class repositoriocompras
    Public Function FindById(ByVal numero As Integer) As MySqlDataReader

        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim consulta As String
        consulta = "select * from v_compras where _id=" & numero
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
        consulta = "select * from v_compras"
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
        consulta = "select * from v_compras"
        Try
            comando = New MySqlCommand(consulta, db)
            datos = comando.ExecuteReader

        Catch ex As Exception

        End Try
        Return datos
    End Function

    Public Function UpdateState(ByVal estado As Integer) As Integer
        Return 1
    End Function

    Public Function Insert(ByVal datos As compra) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Dim sqlinsertdetalle As String
        Dim id As Integer
        Dim Transac As MySqlTransaction
        Try
            db2.Open()
            Transac = db2.BeginTransaction
            sqlinsert = "INSERT INTO compra(_ID,documento,fecha,proveedor__ID,estado_compra__ID,fecha_requerida,subtotal,impuesto,total)
                        VALUES(default,?documento,?fecha,?proveedor__ID,?estado_compra__ID,?fecha_requerida,?subtotal,?impuesto,?total)"
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert

            comando.Parameters.AddWithValue("?documento", datos.xencabezadoCompra.Documento)
            comando.Parameters.AddWithValue("?fecha", datos.xencabezadoCompra.Fecha)
            comando.Parameters.AddWithValue("?proveedor__ID", datos.xencabezadoCompra.Proveedor)
            comando.Parameters.AddWithValue("?estado_compra__ID", datos.xencabezadoCompra.Estado)
            comando.Parameters.AddWithValue("?fecha_requerida", datos.xencabezadoCompra.FechaRequerida)
            comando.Parameters.AddWithValue("?subtotal", datos.xencabezadoCompra.Subtotal)
            comando.Parameters.AddWithValue("?impuesto", datos.xencabezadoCompra.Impuesto)
            comando.Parameters.AddWithValue("?total", datos.xencabezadoCompra.Total)

            comando.ExecuteNonQuery()

            id = comando.LastInsertedId
            comando.Parameters.RemoveAt("?documento")
            comando.Parameters.RemoveAt("?fecha")
            comando.Parameters.RemoveAt("?proveedor__ID")
            comando.Parameters.RemoveAt("?estado_compra__ID")
            comando.Parameters.RemoveAt("?fecha_requerida")
            comando.Parameters.RemoveAt("?subtotal")
            comando.Parameters.RemoveAt("?impuesto")
            comando.Parameters.RemoveAt("?total")
            sqlinsertdetalle = "INSERT INTO compra_detalle(_ID,compra__ID,producto__ID,cantidad,precio,impuesto,subtotal_linea,total_linea)
                           VALUES(default,?compra__ID,?producto__ID,?cantidad,?precio,?impuesto,?subtotal_linea,?total_linea)"
            comando.CommandText = sqlinsertdetalle

            For Each miarticulo In datos.xdetalleCompra
                comando.Parameters.AddWithValue("?compra__ID", id)
                comando.Parameters.AddWithValue("?producto__ID", miarticulo.IdProducto)
                comando.Parameters.AddWithValue("?cantidad", miarticulo.Cantidad)
                comando.Parameters.AddWithValue("?precio", miarticulo.Precio)
                comando.Parameters.AddWithValue("?impuesto", miarticulo.Impuesto)
                comando.Parameters.AddWithValue("?subtotal_linea", miarticulo.Subtotal)
                comando.Parameters.AddWithValue("?total_linea", miarticulo.TotalLinea)
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

    Public Function Update(ByVal datos As compra) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Dim sqlinsertdetalle As String
        Dim id As Integer
        Dim Transac As MySqlTransaction
        Try
            db2.Open()
            Transac = db2.BeginTransaction
            sqlinsert = "update compra SET documento = ?documento,fecha = ?fecha, proveedor__ID = ?proveedor__ID, estado_compra__ID = ?estado_compra__ID, fecha_requerida = ?fecha_requerida,
                        subtotal = ?subtotal,impuesto = ?impuesto,total = ?total WHERE _ID = ?id"
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert

            comando.Parameters.AddWithValue("?documento", datos.xencabezadoCompra.Documento)
            comando.Parameters.AddWithValue("?fecha", datos.xencabezadoCompra.Fecha)
            comando.Parameters.AddWithValue("?proveedor__ID", datos.xencabezadoCompra.Proveedor)
            comando.Parameters.AddWithValue("?estado_compra__ID", datos.xencabezadoCompra.Estado)
            comando.Parameters.AddWithValue("?fecha_requerida", datos.xencabezadoCompra.FechaRequerida)
            comando.Parameters.AddWithValue("?subtotal", datos.xencabezadoCompra.Subtotal)
            comando.Parameters.AddWithValue("?impuesto", datos.xencabezadoCompra.Impuesto)
            comando.Parameters.AddWithValue("?total", datos.xencabezadoCompra.Total)
            comando.Parameters.AddWithValue("?id", datos.xencabezadoCompra.Id)
            comando.ExecuteNonQuery()

            comando.Parameters.RemoveAt("?documento")
            comando.Parameters.RemoveAt("?fecha")
            comando.Parameters.RemoveAt("?proveedor__ID")
            comando.Parameters.RemoveAt("?estado_compra__ID")
            comando.Parameters.RemoveAt("?fecha_requerida")
            comando.Parameters.RemoveAt("?subtotal")
            comando.Parameters.RemoveAt("?impuesto")
            comando.Parameters.RemoveAt("?total")
            comando.Parameters.RemoveAt("?id")

            sqlinsertdetalle = "UPDATE compra_detalle SET  cantidad = ?cantidad, precio = ?precio, impuesto = ?impuesto,
subtotal_linea = ?subtotal_linea, total_linea = ?total_linea WHERE _ID = ?id"
            comando.CommandText = sqlinsertdetalle

            For Each miarticulo In datos.xdetalleCompra
                comando.Parameters.AddWithValue("?cantidad", miarticulo.Cantidad)
                comando.Parameters.AddWithValue("?precio", miarticulo.Precio)
                comando.Parameters.AddWithValue("?impuesto", miarticulo.Impuesto)
                comando.Parameters.AddWithValue("?subtotal_linea", miarticulo.Subtotal)
                comando.Parameters.AddWithValue("?total_linea", miarticulo.TotalLinea)
                comando.Parameters.AddWithValue("?id", miarticulo.Id)
                comando.ExecuteNonQuery()
                comando.Parameters.Clear()
            Next
            Transac.Commit()
            db2.Close()
        Catch ex As Exception
            Transac.Rollback()
            db2.Close()
            Return 1
        End Try
        Return 0
    End Function

    Public Function Delete(ByVal numero As Integer) As Integer
        Return 0
    End Function

    Public Function CargarExistencia(ByVal xcompra As compra) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Dim sqlestado As String
        Dim id As Integer
        Dim Transac As MySqlTransaction
        Try
            db2.Open()
            sqlinsert = "UPDATE articulo_almancen SET existencia =existencia + ?existencia where producto__ID = ?id_producto AND almacen__ID = ?id_almacen"
            Transac = db2.BeginTransaction
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            For Each miarticulo In xcompra.xdetalleCompra
                comando.Parameters.AddWithValue("?existencia", miarticulo.Cantidad)
                comando.Parameters.AddWithValue("?id_producto", miarticulo.IdProducto)
                comando.Parameters.AddWithValue("?id_almacen", 2)
                comando.ExecuteNonQuery()
            Next
            comando.Parameters.RemoveAt("?existencia")
            comando.Parameters.RemoveAt("?id_producto")
            comando.Parameters.RemoveAt("?id_almacen")
            sqlestado = "update compra set estado_compra__ID=3 where _ID=?id"
            comando.CommandText = sqlestado
            comando.Parameters.AddWithValue("?id", xcompra.xencabezadoCompra.Id)
            comando.ExecuteNonQuery()
            Transac.Commit()
            db2.Close()
        Catch ex As Exception
            Transac.Rollback()
            db2.Close()
            Return 1
        End Try

        Return 0
    End Function
End Class
