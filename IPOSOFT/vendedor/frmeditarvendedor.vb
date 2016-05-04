Public Class frmeditarvendedor
    Dim _id As Integer
    Dim xrepo As repoVendedor = New repoVendedor
    Dim xvendedor As vendedor = New vendedor

    Public Property Id As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property
    Private Sub frmeditarvendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        xvendedor = xrepo.findById(Id)
        txtid.Text = xvendedor.Id
        txtnombre.Text = xvendedor.Nombre
        txtdireccion.Text = xvendedor.Direccion
        txttelefono.Text = xvendedor.Telefono
        ckestado.Checked = xvendedor.Estado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Actualizar()
        Dim resultado As Integer = -1
        xvendedor.Nombre = txtnombre.Text
        xvendedor.Direccion = txtdireccion.Text
        xvendedor.Telefono = txttelefono.Text
        xvendedor.Estado = ckestado.Checked
        resultado = xrepo.update(xvendedor)
        If resultado = 0 Then
            MessageBox.Show("El vendedor se actualizo exitosamente", "Creacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Error al momento de actualizar la vendedor", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Actualizar()
    End Sub
End Class
