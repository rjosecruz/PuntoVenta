Imports MySql.Data.MySqlClient
Public Class repositorioProducto

    Public Function findById(ByVal _id As Integer) As producto
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Dim xproducto As producto = New producto
        Try
            sql = "select * from producto where _ID=?_id"
            comando = New MySqlCommand(sql, db)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("?_id", _id)
            datos = comando.ExecuteReader
            If datos.HasRows Then
                While datos.Read
                    xproducto.Id = datos(0)
                    xproducto.CodigoBarras = datos(1)
                    xproducto.CodigoSap = datos(2)
                    xproducto.Descripcion = datos(3)
                    xproducto.Clasificacion = datos(4)
                    xproducto.Marca = datos(5)
                    xproducto.Impuesto = datos(6)
                    xproducto.Precio = datos(7)
                    xproducto.UxC = datos(8)
                    xproducto.Costopromedio = datos(9)
                    xproducto.TiempoReabastecimiento = datos(10)
                    xproducto.SemanasEnMano = datos(11)
                    xproducto.CantidadMaxima = datos(12)
                    xproducto.CantidadMinima = datos(13)
                    xproducto.PuntoReorden = datos(14)
                    xproducto.Estado = datos(15)
                    xproducto.ConsumoPromedio = datos(16)
                End While
            End If
            comando.Dispose()
            datos.Close()
        Catch ex As Exception
            Return xproducto
        End Try
        Return xproducto
    End Function
    Public Function insert(ByVal xproducto As producto) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Dim id_producto As Long
        Try
            sqlinsert = "insert into producto VALUES(default,?codigo_barra,?codigo_sap,?descripcion,?clasificacion_ID,?marca_ID,?impuesto_ID,
                                                        ?precio,?unidades_por_caja,?costo_promedio,?tiempo_reabastecimiento_semana,
                                                        ?semanas_en_mano,?cantidad_maxima,?cantidad_minima,?punto_reorden,?estado,?consumopromedio)"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert

            comando.Parameters.AddWithValue("?codigo_barra", xproducto.CodigoBarras)
            comando.Parameters.AddWithValue("?codigo_sap", xproducto.CodigoSap)
            comando.Parameters.AddWithValue("?descripcion", xproducto.Descripcion)
            comando.Parameters.AddWithValue("clasificacion_ID", xproducto.Clasificacion)
            comando.Parameters.AddWithValue("?marca_ID", xproducto.Marca)
            comando.Parameters.AddWithValue("?impuesto_ID", xproducto.Impuesto)
            comando.Parameters.AddWithValue("?precio", xproducto.Precio)
            comando.Parameters.AddWithValue("?unidades_por_caja", xproducto.UxC)
            comando.Parameters.AddWithValue("?costo_promedio", xproducto.ConsumoPromedio)
            comando.Parameters.AddWithValue("?tiempo_reabastecimiento_semana", xproducto.TiempoReabastecimiento)
            comando.Parameters.AddWithValue("?semanas_en_mano", xproducto.SemanasEnMano)
            comando.Parameters.AddWithValue("?cantidad_maxima", xproducto.CantidadMaxima)
            comando.Parameters.AddWithValue("?cantidad_minima", xproducto.CantidadMinima)
            comando.Parameters.AddWithValue("?punto_reorden", xproducto.PuntoReorden)
            comando.Parameters.AddWithValue("?estado", xproducto.Estado)
            comando.Parameters.AddWithValue("?consumopromedio", xproducto.ConsumoPromedio)
            comando.ExecuteNonQuery()
            id_producto = comando.LastInsertedId
            Return id_producto
        Catch ex As Exception
            Return -1
        End Try
        Return 0
    End Function
    Public Function query() As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sql As String
        Try
            sql = "select * from producto"
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
            sql = "select * from producto where descripcion like '%" + filtro + "%'"
            comando = New MySqlCommand(sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception
            Return datos
        End Try
        Return datos
    End Function
    Public Function update(ByVal xproducto As producto) As Integer

        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String
        Try
            sqlinsert = "UPDATE producto SET codigo_barra = ?codigo_barra, codigo_sap = ?codigo_sap, descripcion = ?descripcion,
                            clasificacion__ID = ?clasificacion_ID,marca__ID = ?marca_ID,impuesto__ID = ?impuesto_ID,precio = ?precio,
                            unidades_por_caja = ?unidades_por_caja,costo_promedio = ?costo_promedio,tiempo_reabastecimiento_semana = ?tiempo_reabastecimiento_semana,
                            semanas_en_mano = ?semanas_en_mano,cantidad_maxima = ?cantidad_maxima,cantidad_minima = ?cantidad_minima,punto_reorden = ?punto_reorden,
                            estado = ?estado,consumopromedio = ?consumopromedio WHERE _ID = ?_id"
            comando.Connection = db
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?codigo_barra", xproducto.CodigoBarras)
            comando.Parameters.AddWithValue("?codigo_sap", xproducto.CodigoSap)
            comando.Parameters.AddWithValue("?descripcion", xproducto.Descripcion)
            comando.Parameters.AddWithValue("clasificacion_ID", xproducto.Clasificacion)
            comando.Parameters.AddWithValue("?marca_ID", xproducto.Marca)
            comando.Parameters.AddWithValue("?impuesto_ID", xproducto.Impuesto)
            comando.Parameters.AddWithValue("?precio", xproducto.Precio)
            comando.Parameters.AddWithValue("?unidades_por_caja", xproducto.UxC)
            comando.Parameters.AddWithValue("?costo_promedio", xproducto.ConsumoPromedio)
            comando.Parameters.AddWithValue("?tiempo_reabastecimiento_semana", xproducto.TiempoReabastecimiento)
            comando.Parameters.AddWithValue("?semanas_en_mano", xproducto.SemanasEnMano)
            comando.Parameters.AddWithValue("?cantidad_maxima", xproducto.CantidadMaxima)
            comando.Parameters.AddWithValue("?cantidad_minima", xproducto.CantidadMinima)
            comando.Parameters.AddWithValue("?punto_reorden", xproducto.PuntoReorden)
            comando.Parameters.AddWithValue("?estado", xproducto.Estado)
            comando.Parameters.AddWithValue("?consumopromedio", xproducto.ConsumoPromedio)
            comando.Parameters.AddWithValue("?_id", xproducto.Id)
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
            sqldelete = "delete from producto where _ID=?_id"
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
