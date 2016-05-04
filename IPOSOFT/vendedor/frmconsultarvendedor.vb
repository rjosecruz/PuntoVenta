Public Class frmconsultarvendedor
    Dim _id As Integer
    Dim xrepor As repoVendedor = New repoVendedor
    Dim xvendedor As vendedor = New vendedor
    Public Property Id As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub frmconsultarvendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Sub Cargar()
        xvendedor = xrepor.findById(Me.Id)
        txtid.Text = xvendedor.Id
        txtnombre.Text = xvendedor.Nombre
        txtdireccion.Text = xvendedor.Direccion
        txttelefono.Text = xvendedor.Telefono
        ckestado.Checked = xvendedor.Estado
    End Sub
End Class
