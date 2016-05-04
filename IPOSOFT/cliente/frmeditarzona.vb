Public Class frmeditarzona
    Dim guardado As Boolean = False
    Private _ID As Integer
    Private xrepo As zonaRepositorio
    Dim xzona As Zona
    Public Property ID As Integer
        Get
            Return Me._ID
        End Get
        Set(value As Integer)
            Me._ID = value
        End Set
    End Property
    Private Sub frmeditarzona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la edicion de la zona?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Sub Cargar()
        xzona = New Zona
        xrepo = New zonaRepositorio
        xzona = xrepo.findById(Me.ID)
        txtidzona.Text = xzona.ID
        txtzona.Text = xzona.zona
        ckestado.Checked = xzona.estado
    End Sub
    Sub Limpiar()
        txtzona.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Actualizar()
    End Sub

    Sub Actualizar()
        Dim resultado As Integer = -1
        xzona.ID = txtidzona.Text
        xzona.zona = txtzona.Text
        xzona.estado = ckestado.Checked
        resultado = xrepo.update(xzona)
        If resultado = 0 Then
            MessageBox.Show("La zona se actualizo exitosamente", "Creacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)

            guardado = True
        Else
            MessageBox.Show("Error al momento de actualizar la zona", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtzona_LostFocus(sender As Object, e As EventArgs) Handles txtzona.LostFocus
        txtzona.Text = StrConv(txtzona.Text, vbProperCase)
    End Sub
End Class
