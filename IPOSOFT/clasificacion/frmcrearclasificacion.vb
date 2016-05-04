Public Class frmcrearclasificacion
    Dim guardado As Boolean
    Private Sub frmcrearclasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion de la marca?", "Confirmar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtclasificacion.Text = ""
    End Sub

    Sub guardar()
        Dim resultado As Integer
        Dim xclasificacion As clasificacion = New clasificacion
        xclasificacion.Clasificacion = txtclasificacion.Text
        Dim xrepo As repoclasificacion = New repoclasificacion
        resultado = xrepo.insert(xclasificacion)
        If resultado = 0 Then
            MessageBox.Show("La clasificacion se creo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            guardado = True
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtclasificacion_LostFocus(sender As Object, e As EventArgs) Handles txtclasificacion.LostFocus
        txtclasificacion.Text = StrConv(txtclasificacion.Text, vbProperCase)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtclasificacion.Text)) > 0 Then
            guardar()
        Else
            MessageBox.Show("Escriba la clasificacion", "Información incompleta",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
