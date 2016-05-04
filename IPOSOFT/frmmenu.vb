Public Class frmmenu
    Private Sub MetroTabPanel1_Click(sender As Object, e As EventArgs) Handles MetroTabPanel1.Click

    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        Dim producto As frmlistaprodutos
        producto = New frmlistaprodutos
        producto.MdiParent = Me
        producto.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim zonas As frmzonacliente
        zonas = New frmzonacliente
        zonas.MdiParent = Me
        zonas.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim vendedores As frmlistavendedores
        vendedores = New frmlistavendedores
        vendedores.MdiParent = Me
        vendedores.Show()

    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        Dim clientes As frmclientes = New frmclientes
        clientes.MdiParent = Me
        clientes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim impuesto As frmimpuestos = New frmimpuestos
        impuesto.MdiParent = Me
        impuesto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marcas As frmmarcas = New frmmarcas
        marcas.MdiParent = Me
        marcas.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clasificacion As frmclasificacion = New frmclasificacion
        clasificacion.MdiParent = Me
        clasificacion.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim almacen As frmalmacenes = New frmalmacenes
        almacen.MdiParent = Me
        almacen.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim proveedores As frmproveedores = New frmproveedores
        proveedores.MdiParent = Me
        proveedores.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim compras As frmcompras = New frmcompras
        compras.MdiParent = Me
        compras.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ventas As frmventas = New frmventas
        ventas.MdiParent = Me
        ventas.Show()
    End Sub
End Class
