Option Strict Off
Public Class frmcrearcompra
    Dim fila As Integer
    Dim row As DataGridViewRow
    Dim xrepoproducto As repositorioProducto = New repositorioProducto
    Dim xrepoproveedor As repoitorioProveedor = New repoitorioProveedor
    Dim xproveedor As proveedor = New proveedor
    Dim xproducto As producto = New producto
    Dim xcompra As compra = New compra
    Dim xdetallecompra As detalleCompra
    Dim guardado As Boolean = False
    Dim _idproveedor As Integer
    Public Property Idproveedor As Integer
        Get
            Return _idproveedor
        End Get
        Set(value As Integer)
            _idproveedor = value
        End Set
    End Property
    Dim _idproducto As Integer
    Public Property IdProducto As Integer
        Get
            Return _idproducto
        End Get
        Set(value As Integer)
            _idproducto = value
        End Set
    End Property
    Private Sub btncerrar_Click(sender As Object, e As EventArgs)
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click

        Dim buscarproveedor As frmbuscarproveedor = New frmbuscarproveedor
        buscarproveedor.Origen = 1
        buscarproveedor.ObjectOrigen = Me
        buscarproveedor.ShowDialog()

        cargarProveedor()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Idproveedor > 0 Then
            Dim buscarproducto As frmbuscarproducto = New frmbuscarproducto
            buscarproducto.ObjectOrigen = Me
            buscarproducto.ShowDialog()
            AgregarProducto()
        Else
            MessageBox.Show("Antes de agregar productos debe elegir el proveedor", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmcrearcompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncerrar_Click_1(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion de la compra?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub
    Sub cargarProveedor()
        If Idproveedor <> 0 Then
            xproveedor = xrepoproveedor.findById(Idproveedor)
            txtcodigoproveedor.Text = xproveedor.Id
            txtnombre.Text = xproveedor.Nombre
        End If

    End Sub
    Sub AgregarProducto()
        xproducto = xrepoproducto.findById(IdProducto)

        dgarticulos.Rows.Add(xproducto.Id, xproducto.Descripcion, 0, 0, 0, 0, 0)

    End Sub

    Private Sub dgarticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellContentClick

    End Sub

    Private Sub dgarticulos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgarticulos.CellBeginEdit
        fila = dgarticulos.CurrentRow.Index
        row = dgarticulos.CurrentRow
    End Sub
    Sub calcularFila()
        row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
        row.Cells(6).Value = row.Cells(4).Value + row.Cells(5).Value
        ProcesarCompra()
    End Sub

    Private Sub dgarticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellEndEdit
        calcularFila()
    End Sub
    Sub ProcesarCompra()
        xcompra.xencabezadoCompra.Estado = 1
        xcompra.xencabezadoCompra.Documento = txtdocumento.Text
        xcompra.xencabezadoCompra.Fecha = dtfecha.Value
        xcompra.xencabezadoCompra.FechaRequerida = dtvencimiento.Value
        xcompra.xencabezadoCompra.Proveedor = txtcodigoproveedor.Text
        xcompra.xencabezadoCompra.Subtotal = 0
        xcompra.xencabezadoCompra.Impuesto = 0
        xcompra.xencabezadoCompra.Total = 0
        xcompra.xdetalleCompra.Clear()

        For Each row As DataGridViewRow In dgarticulos.Rows
            xdetallecompra = New detalleCompra
            xdetallecompra.IdProducto = row.Cells(0).Value
            xdetallecompra.Cantidad = row.Cells(2).Value
            xdetallecompra.Precio = row.Cells(3).Value
            xdetallecompra.Subtotal = row.Cells(4).Value
            xdetallecompra.Impuesto = row.Cells(5).Value
            xdetallecompra.TotalLinea = row.Cells(6).Value
            xcompra.xencabezadoCompra.Subtotal = xcompra.xencabezadoCompra.Subtotal + xdetallecompra.Subtotal
            xcompra.xencabezadoCompra.Impuesto = xcompra.xencabezadoCompra.Impuesto + xdetallecompra.Impuesto
            xcompra.xencabezadoCompra.Total = xcompra.xencabezadoCompra.Total + xdetallecompra.TotalLinea
            xcompra.xdetalleCompra.Add(xdetallecompra)
            lblsubtotal.Text = xcompra.xencabezadoCompra.Subtotal
            lblimpuesto.Text = xcompra.xencabezadoCompra.Impuesto
            lbltotal.Text = xcompra.xencabezadoCompra.Total
        Next
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim resultado As Integer
        If Len(Trim(txtdocumento.Text)) > 0 And Len(Trim(txtcodigoproveedor.Text)) > 0 And dgarticulos.RowCount > 0 Then
            ProcesarCompra()
            Dim xrepo As repositoriocompras = New repositoriocompras
            resultado = xrepo.Insert(xcompra)
            If resultado = 0 Then
                MessageBox.Show("El compra se creo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnguardar.Enabled = False
                guardado = True
            Else
                MessageBox.Show("Error al momento de crear a compra", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("El numero de documento/codigo proveedor son obligatorios", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
End Class
