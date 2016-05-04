Imports MySql.Data.MySqlClient
Public Class repositorioProductoAlmacen
    Dim _existencia As Double
    Public Property Existencia As Double
        Get
            Return _existencia
        End Get
        Set(value As Double)
            _existencia = value
        End Set
    End Property
    Public Function findById() As productoalmacen

        Dim xproductoalmacen As productoalmacen = New productoalmacen
        Return xproductoalmacen
    End Function

    Public Function Query(ByVal id As Integer) As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim sumcantidad As Double
        Dim _sql As String
        Dim comando As MySqlCommand
        Try
            _sql = "select * from v_producto_almacen where producto__ID=" & id
            comando = New MySqlCommand(_sql, db)
            datos = comando.ExecuteReader
            comando.Dispose()
        Catch ex As Exception

        End Try
        Existencia = sumcantidad
        Return datos
    End Function
    Public Function insert(ByVal id As Integer) As Integer
        Dim comando As MySqlCommand = New MySqlCommand

        Dim sqlinsert As String
        Dim xrepo As repositorioAlmacen = New repositorioAlmacen
        Dim datos As MySqlDataReader
        datos = xrepo.query

        Dim Transac As MySqlTransaction


        Try
            db2.Open()
            Transac = db2.BeginTransaction
            sqlinsert = "insert into articulo_almancen values(default,?producto_id,?almacen_id,?existencia)"
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            If datos.HasRows Then
                While datos.Read
                    comando.Parameters.AddWithValue("?producto_id", id)
                    comando.Parameters.AddWithValue("?almacen_id", datos(0))
                    comando.Parameters.AddWithValue("?existencia", 0)

                    comando.ExecuteNonQuery()
                    comando.Parameters.Clear()
                End While
            End If
            datos.Close()
            Transac.Commit()
            db2.Close()
            Return 0
        Catch ex As Exception
            Transac.Rollback()
            Return 1
        End Try
        Return 0
    End Function
End Class
