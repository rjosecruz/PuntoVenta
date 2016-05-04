Public Class frmeditarmarca
    Dim xmarca As marca = New marca
    Dim xrepo As repomarca = New repomarca
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmeditarmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cargar()
        xmarca = xrepo.findById(Id)
        txtid.Text = xmarca.Id
        txtmarca.Text = xmarca.Marca
        ckestado.Checked = xmarca.Estado
    End Sub

    Sub Actualizar()
        Dim resultado As Integer
        xmarca.Marca = txtmarca.Text
        xmarca.Estado = ckestado.Checked
        resultado = xrepo.update(xmarca)
        If resultado = 0 Then
            MessageBox.Show("La marca se actualizo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub
    Sub Limpiar()
        txtmarca.Text = ""
        ckestado.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(Trim(txtmarca.Text)) > 0 Then
            Actualizar()
        Else
            MessageBox.Show("Todos los datos son obligatorios", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
