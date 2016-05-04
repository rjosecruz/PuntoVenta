Imports MySql.Data.MySqlClient

Public Class repositorioPago

    Public Function Insert(ByVal xpago As pago) As Integer
        Dim comando As MySqlCommand = New MySqlCommand
        Dim sqlinsert As String

        Dim Transac As MySqlTransaction
        Try
            db2.Open()
            Transac = db2.BeginTransaction
            sqlinsert = "INSERT INTO factura_pago(_ID,fecha,tipo_documento__ID,numero_documento,saldo_anterior,pago,saldo_nuevo,factura__ID,vendedor__ID)
            VALUES(default,?fecha,?tipo_documento__ID,?numero_documento,?saldo_anterior,?pago,?saldo_nuevo,?factura__ID,?vendedor__ID)"
            comando.Connection = db2
            comando.Transaction = Transac
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlinsert
            comando.Parameters.AddWithValue("?fecha", xpago.Fecha)
            comando.Parameters.AddWithValue("?tipo_documento__ID", xpago.TipoDocumento)
            comando.Parameters.AddWithValue("?numero_documento", xpago.NumeroDocumento)
            comando.Parameters.AddWithValue("?saldo_anterior", xpago.SaldoAnterior)
            comando.Parameters.AddWithValue("?pago", xpago.Pago)
            comando.Parameters.AddWithValue("?saldo_nuevo", xpago.SaldoNuevo)
            comando.Parameters.AddWithValue("?factura__ID", xpago.Factura)
            comando.Parameters.AddWithValue("vendedor__ID", xpago.Vendedor)
            comando.ExecuteNonQuery()

            comando.Parameters.RemoveAt("?fecha")
            comando.Parameters.RemoveAt("?tipo_documento__ID")
            comando.Parameters.RemoveAt("?numero_documento")
            comando.Parameters.RemoveAt("?saldo_anterior")
            comando.Parameters.RemoveAt("?pago")
            comando.Parameters.RemoveAt("?saldo_nuevo")
            comando.Parameters.RemoveAt("?factura__ID")

            Dim sqlsaldocliente As String
            sqlsaldocliente = "update factura set saldo=saldo-?pago where _ID=?id_factura"
            comando.CommandText = sqlsaldocliente
            comando.Parameters.AddWithValue("?pago", xpago.Pago)
            comando.Parameters.AddWithValue("?id_factura", xpago.Factura)
            comando.ExecuteNonQuery()

            Transac.Commit()
        Catch ex As Exception
            Transac.Rollback()
            Return 1
        End Try

        Return 0
    End Function

    Public Function FindByID(ByVal xid As Integer) As MySqlDataReader
        Dim datos As MySqlDataReader
        Dim comando As MySqlCommand
        Dim sqldatos As String

        Try
            sqldatos = "select * from v_pagos where _ID=?factura"
            comando = New MySqlCommand(sqldatos, db)
            comando.Parameters.AddWithValue("?factura", xid)
            datos = comando.ExecuteReader
        Catch ex As Exception

        End Try
        Return datos
    End Function
End Class
