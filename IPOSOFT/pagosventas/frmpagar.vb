Imports MySql.Data.MySqlClient

Public Class frmpagar
    Dim xrepovendedor As repoVendedor = New repoVendedor
    Dim vendedorreader As MySqlDataReader
    Dim xrepo As repositorioventa = New repositorioventa
    Dim repopago As repositorioPago = New repositorioPago
    Dim xpago As pago = New pago
    Dim datos As MySqlDataReader
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Function GetDocumentosItems() As List(Of tipodocumento)
        Dim documentosItems = New List(Of tipodocumento)
        Dim datos As MySqlDataReader
        Dim xrepo As repositorioHelpers = New repositorioHelpers
        datos = xrepo.FindAllTipoDocumentos()
        If datos.HasRows = True Then
            While datos.Read()
                documentosItems.Add(New tipodocumento(datos(0), datos(1)))
            End While

        End If
        datos.Close()
        Return documentosItems
    End Function

    Private Sub frmpagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipo()
        Cargar()
        CargarVendedores()
    End Sub

    Sub CargarTipo()
        cmbtipodocumento.ValueMember = "_ID"
        cmbtipodocumento.DisplayMember = "tipo"
        cmbtipodocumento.DataSource = GetDocumentosItems()
    End Sub
    Sub Cargar()
        datos = xrepo.FindById(Id)
        If datos.HasRows Then
            While datos.Read
                txtdocumento.Text = datos(0)
                txtsaldo.Text = datos(19)
            End While
        End If
        datos.Close()
    End Sub

    Private Sub txtpago_ValueChanged(sender As Object, e As EventArgs) Handles txtpago.ValueChanged
        Calcular()
    End Sub

    Sub Calcular()
        txtsaldonuevo.Value = txtsaldo.Value - txtpago.Value
    End Sub

    Sub pagar()
        Dim oItems As vendedor = CType(cmbvendedor.SelectedItem, vendedor)
        Dim oItemsz As tipodocumento = CType(cmbtipodocumento.SelectedItem, tipodocumento)
        xpago.Factura = txtdocumento.Text
        xpago.Fecha = Now
        xpago.NumeroDocumento = txtrecibo.Text
        xpago.SaldoAnterior = txtsaldo.Value
        xpago.Pago = txtpago.Value
        xpago.SaldoNuevo = txtsaldonuevo.Value
        xpago.TipoDocumento = oItemsz.Id
        xpago.Vendedor = oItems.Id
        Dim resultado As Integer
        resultado = repopago.Insert(xpago)
        If resultado = 0 Then
            MessageBox.Show("El pago se aplico exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False

        Else
            MessageBox.Show("Error al momento de aplicar el pago", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub CargarVendedores()
        cmbvendedor.ValueMember = "_ID"
        cmbvendedor.DisplayMember = "nombre"
        cmbvendedor.DataSource = GetVendedorItems()
    End Sub
    Function GetVendedorItems() As List(Of vendedor)
        Dim vendedorItems = New List(Of vendedor)
        vendedorreader = xrepovendedor.query

        If vendedorreader.HasRows = True Then
            While vendedorreader.Read()
                vendedorItems.Add(New vendedor(vendedorreader(0), vendedorreader(1)))
            End While
            vendedorreader.Close()
        End If
        Return vendedorItems
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Id <> 0 And Len(Trim(txtrecibo.Text)) > 0 And Len(Trim(txtpago.Text)) > 0 Then
            If txtsaldonuevo.Value < 0 Then
                MessageBox.Show("El monto del pago es superior al saldo, favor revice los datos", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                pagar()
            End If
        End If
    End Sub
End Class
