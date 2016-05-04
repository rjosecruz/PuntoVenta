Public Class frmeditarclasificacion
    Dim _id As Integer
    Dim xrepor As repoclasificacion = New repoclasificacion
    Dim xclasificacion As clasificacion = New clasificacion
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmeditarclasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        xclasificacion = xrepor.findById(Id)
        txtid.Text = xclasificacion.Id
        txtclasificacion.Text = xclasificacion.Clasificacion
        ckestado.Checked = xclasificacion.Estado
    End Sub
    Sub Guardar()
        xclasificacion.Clasificacion = txtclasificacion.Text
        xclasificacion.Estado = ckestado.Checked
        Dim resultado As Integer
        resultado = xrepor.update(xclasificacion)
        If resultado = 0 Then
            MessageBox.Show("La clasificacion se actualizo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub txtclasificacion_LostFocus(sender As Object, e As EventArgs) Handles txtclasificacion.LostFocus
        txtclasificacion.Text = StrConv(txtclasificacion.Text, vbProperCase)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(Trim(txtclasificacion.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Todos los datos son obligatorios", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
