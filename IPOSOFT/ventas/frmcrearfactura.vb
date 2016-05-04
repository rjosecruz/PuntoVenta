Imports MySql.Data.MySqlClient

Public Class frmcrearfactura
    Dim xrepovendedor As repoVendedor = New repoVendedor
    Dim vendedorreader As MySqlDataReader
    Dim xrepoproducto As repositorioProducto = New repositorioProducto
    Dim xrepocliente As repocliente = New repocliente
    Dim xproducto As producto = New producto
    Dim xcliente As cliente = New cliente
    Dim guardado As Boolean = False
    Dim fila As Integer
    Dim row As DataGridViewRow
    Dim xfactura As factura = New factura
    Dim xdetallefactura As detallefactura
    Dim oItems As vendedor = New vendedor
    Dim xrepo As repositorioventa = New repositorioventa
    Dim _idproducto As Integer
    Public Property IdProducto As Integer
        Get
            Return _idproducto
        End Get
        Set(value As Integer)
            _idproducto = value
        End Set
    End Property
    Dim _idcliente As Integer
    Public Property IdCliente As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
        End Set
    End Property

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion de la factura?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub
    Sub Cerrar()
        Me.Dispose()
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


    Private Sub frmcrearfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVendedores()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IdCliente > 0 Then
            Dim buscarproducto As frmbuscarproducto = New frmbuscarproducto
            buscarproducto.ObjectOrigen = Me
            buscarproducto.ShowDialog()
            AgregarProducto()
        Else
            MessageBox.Show("Antes de agregar productos debe elegir el cliente", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Sub AgregarProducto()
        xproducto = xrepoproducto.findById(IdProducto)
        xproducto.getExtras()

        dgarticulos.Rows.Add(xproducto.Id, xproducto.Descripcion, 1, xproducto.Precio, 0, 0, 0, xproducto.xImpuesto.Porcentaje, xproducto.xImpuesto.Id)

    End Sub

    Private Sub dgarticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellContentClick

    End Sub

    Private Sub dgarticulos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgarticulos.CellBeginEdit
        fila = dgarticulos.CurrentRow.Index
        row = dgarticulos.CurrentRow
    End Sub

    Private Sub dgarticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellEndEdit
        calcularFila()
    End Sub
    Sub calcularFila()
        Dim subtotal, impuesto As Double
        subtotal = row.Cells(3).Value * row.Cells(2).Value
        row.Cells(4).Value = subtotal
        impuesto = subtotal * row.Cells(7).Value / 100
        row.Cells(5).Value = impuesto
        row.Cells(6).Value = subtotal + impuesto
        procesar()
    End Sub

    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        Dim buscarcliente As frmbuscarcliente = New frmbuscarcliente
        buscarcliente.ObjectOrigen = Me
        buscarcliente.ShowDialog()
        CargarCliente()
    End Sub
    Sub CargarCliente()
        xcliente = xrepocliente.findById(IdCliente)
        If xcliente.Id <> 0 Then
            txtcodigocliente.Text = xcliente.Id
            txtnombre.Text = xcliente.Nombre
        Else
            MessageBox.Show("Antes de agregar productos debe elegir el cliente", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub procesar()
        oItems = CType(cmbvendedor.SelectedItem, vendedor)
        xfactura.xencabezadofactura.CAI = ""
        xfactura.xencabezadofactura.DiasCredito = 0
        xfactura.xencabezadofactura.EstadoFactura = 1
        xfactura.xencabezadofactura.EstadoPago = 1
        xfactura.xencabezadofactura.Fecha = dtfecha.Value
        xfactura.xencabezadofactura.IdCliente = txtcodigocliente.Text
        xfactura.xencabezadofactura.TipoFactura = "Contado"
        xfactura.xencabezadofactura.Vendedor = oItems.Id
        xfactura.xdetalleFactura.Clear()
        Dim total, impuesto, subtotal As Double
        For Each row As DataGridViewRow In dgarticulos.Rows
            xdetallefactura = New detallefactura
            xdetallefactura.IdProducto = row.Cells(0).Value
            xdetallefactura.Cantidad = row.Cells(2).Value
            xdetallefactura.Precio = row.Cells(3).Value
            xdetallefactura.Subtotal = row.Cells(4).Value
            xdetallefactura.Impuesto = row.Cells(5).Value
            xdetallefactura.Total = row.Cells(6).Value
            xdetallefactura.IdImpuesto = row.Cells(8).Value
            subtotal = subtotal + xdetallefactura.Subtotal
            impuesto = impuesto + xdetallefactura.Impuesto
            total = subtotal + impuesto
            xfactura.xdetalleFactura.Add(xdetallefactura)
        Next
        lblsubtotal.Text = subtotal
        lblimpuesto.Text = impuesto
        lbltotal.Text = total
        xfactura.xencabezadofactura.Subtotal = subtotal
        xfactura.xencabezadofactura.Impuesto = impuesto
        xfactura.xencabezadofactura.Total = total
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtcodigocliente.Text)) > 0 And dgarticulos.RowCount > 0 Then
            procesar()
            Dim resultado As Integer
            resultado = xrepo.Insert(xfactura)
            If resultado = 0 Then
                MessageBox.Show("El factura se creo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnguardar.Enabled = False
                guardado = True
            Else
                MessageBox.Show("Error al momento de crear la factura", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
