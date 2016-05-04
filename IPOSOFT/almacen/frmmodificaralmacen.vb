Public Class frmmodificaralmacen
    Dim xrepo As repositorioAlmacen = New repositorioAlmacen
    Dim xalmacen As almacen = New almacen
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Sub frmmodificaralmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        xalmacen = xrepo.findById(Id)
        txtid.Text = xalmacen.Id
        txtalmacen.Text = xalmacen.Almacen
        txtdireccion.Text = xalmacen.Direccion
        ckestado.Checked = xalmacen.Estado
    End Sub

    Sub Actualizar()
        xalmacen.Almacen = txtalmacen.Text
        xalmacen.Direccion = txtdireccion.Text
        xalmacen.Estado = ckestado.Checked
        Dim resultado As Integer
        resultado = xrepo.update(xalmacen)
        If resultado = 0 Then
            MessageBox.Show("El almacen se actualizo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(Trim(txtalmacen.Text)) > 0 Then
            Actualizar()
        Else
            MessageBox.Show("Debe escribir el nombre del almacen", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        txtalmacen.Text = ""
        txtdireccion.Text = ""
    End Sub

    Private Sub txtalmacen_LostFocus(sender As Object, e As EventArgs) Handles txtalmacen.LostFocus
        txtalmacen.Text = StrConv(txtalmacen.Text, vbProperCase)
    End Sub
End Class
