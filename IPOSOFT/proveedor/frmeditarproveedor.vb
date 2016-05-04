Public Class frmeditarproveedor

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
    Private Sub frmeditarproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub
    Sub limpiar()
        txtid.Text = ""
        txtnombre.Text = ""
        txtrepresentante.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtmail.Text = ""
        txtpais.Text = ""
        txtsaldo.Value = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(Trim(txtnombre.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Escriba el nombre del proveedor", "Información incompleta",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub Guardar()
        xproveedor.Codigo = txtid.Text
        xproveedor.Nombre = txtnombre.Text
        xproveedor.Representante = txtrepresentante.Text
        xproveedor.Direccion = txtdireccion.Text
        xproveedor.Telefono = txttelefono.Text
        xproveedor.Mail = txtmail.Text
        xproveedor.Pais = txtpais.Text
        xproveedor.Saldo = txtsaldo.Value
        xproveedor.Estado = ckestado.Checked
        Dim resultado As Integer
        resultado = xrepo.update(xproveedor)
        If resultado = 0 Then
            MessageBox.Show("El proveedor se actualizo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Error al intentar actualizar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
End Class
