Imports MySql.Data.MySqlClient

Public Class frmeditarcompra
    Dim fila As Integer
    Dim row As DataGridViewRow
    Dim xcompra As compra = New compra
    Dim xdetallecompra As detalleCompra
    Dim xrepo As repositoriocompras = New repositoriocompras
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
        If MessageBox.Show("¿Desea cargar las existencias al inventario?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ProcesarCompra()
            CargarExistencia()

        End If
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub frmeditarcompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        txtid.Text = Id
        datos = xrepo.FindById(Id)
        If datos.HasRows Then
            While datos.Read
                txtcodigoproveedor.Text = datos(6)
                txtnombre.Text = datos(22)
                txtdocumento.Text = datos(1)
                dtfecha.Value = datos(2)
                dtvencimiento.Value = datos(8)
                lblsubtotal.Text = datos(9)
                lblimpuesto.Text = datos(10)
                lbltotal.Text = datos(11)
                dgarticulos.Rows.Add(datos(23), datos("descripcion"), datos("cantidad"), datos("precio"), datos("subtotal_linea"), datos("impuesto_linea"), datos("total_linea"), datos("id_linea"))

            End While
        End If
        datos.Close()
    End Sub

    Private Sub dgarticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellContentClick

    End Sub

    Private Sub dgarticulos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgarticulos.CellBeginEdit
        fila = dgarticulos.CurrentRow.Index
        row = dgarticulos.CurrentRow
    End Sub

    Private Sub dgarticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgarticulos.CellEndEdit
        calcularFila()
        ProcesarCompra()
    End Sub
    Sub calcularFila()
        row.Cells(4).Value = row.Cells(3).Value * row.Cells(2).Value
        row.Cells(6).Value = row.Cells(4).Value + row.Cells(5).Value
    End Sub
    Sub ProcesarCompra()
        xcompra.xencabezadoCompra.Id = txtid.Text
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
            xdetallecompra.Id = row.Cells(7).Value

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
            resultado = xrepo.Update(xcompra)
            If resultado = 0 Then
                MessageBox.Show("El compra se actualizo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnguardar.Enabled = False
            Else
                MessageBox.Show("Error al momento de actualizar la compra", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("El numero de documento/codigo proveedor son obligatorios", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cerrar()
    End Sub
    Sub CargarExistencia()
        Dim resultado As Integer
        resultado = xrepo.CargarExistencia(xcompra)
        If resultado = 0 Then
            MessageBox.Show("El compra se cargo al inventario exitosamente", "Creacion exitosa",
MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False
        Else
            MessageBox.Show("Error al momento de cargar la compra", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
