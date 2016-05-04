Public Class frmconsultarproveedor
    Dim xrepo As repoitorioProveedor = New repoitorioProveedor
    Dim xproveedor As proveedor = New proveedor
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmconsultarproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        xproveedor = xrepo.findById(Id)
        txtid.Text = xproveedor.Id
        txtcodigo.Text = xproveedor.Codigo
        txtnombre.Text = xproveedor.Nombre
        txtrepresentante.Text = xproveedor.Representante
        txtdireccion.Text = xproveedor.Direccion
        txttelefono.Text = xproveedor.Telefono
        txtmail.Text = xproveedor.Mail
        txtpais.Text = xproveedor.Pais
        ckestado.Checked = xproveedor.Estado
        txtsaldo.Text = xproveedor.Saldo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub
End Class
