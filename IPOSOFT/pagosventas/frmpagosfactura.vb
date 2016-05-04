Imports MySql.Data.MySqlClient

Public Class frmpagosfactura
    Dim xrepo As repositorioventa = New repositorioventa
    Dim datos As MySqlDataReader
    Public _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmpagosfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        datos = xrepo.FindById(Id)
        If datos.HasRows Then
            While datos.Read
                txtdocumento.Text = datos(0)
                dtfecha.Value = datos(2)
                txtsaldo.Text = datos(19)
                txtcodigocliente.Text = datos(8)
                txtnombre.Text = datos(13)
            End While
        End If
        datos.Close()
        Dim xrepopago As repositorioPago = New repositorioPago
        datos = xrepopago.FindByID(Id)
        If datos.HasRows Then
            While datos.Read
                dgpagos.Rows.Add(datos("referencia"), datos("fecha_pago"), datos("tipo"), datos("recibo"), datos("saldo_anterior"), datos("pago"), datos("saldo_nuevo"))
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Dim pagarx As frmpagar = New frmpagar
        pagarx.Id = Id
        pagarx.ShowDialog()
        dgpagos.Rows.Clear()
        Cargar()
    End Sub
End Class
