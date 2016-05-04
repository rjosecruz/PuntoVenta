Public Class frmeditarimpuesto
    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim ximpuesto As impuesto = New impuesto
    Dim xrepoimpuesto As repoimpuesto = New repoimpuesto
    Private Sub frmeditarimpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Sub Cargar()
        ximpuesto = xrepoimpuesto.findById(Id)
        txtimpuesto.Text = ximpuesto.Impuesto
        txtid.Text = ximpuesto.Id
        txtporcentaje.Text = ximpuesto.Porcentaje
        ckestado.Checked = ximpuesto.Estado
    End Sub
    Sub Guardar()
        ximpuesto.Impuesto = txtimpuesto.Text
        ximpuesto.Porcentaje = txtporcentaje.Text
        ximpuesto.Estado = ckestado.Checked
        Dim resultado As Integer
        resultado = xrepoimpuesto.update(ximpuesto)
        If resultado = 0 Then
            MessageBox.Show("El impuesto se actualizo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al intentar actualizar los datos", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(Trim(txtimpuesto.Text)) > 0 And Len(Trim(txtporcentaje.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Todos los datos son obligatorios", "Falta Informacion",
       MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Sub Limpiar()
        txtimpuesto.Text = ""

    End Sub
End Class
