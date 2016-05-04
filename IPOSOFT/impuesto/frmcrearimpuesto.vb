Public Class frmcrearimpuesto
    Dim ximpuesto As impuesto = New impuesto
    Dim xrepo As repoimpuesto = New repoimpuesto
    Dim guardado As Boolean = False
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion del impuesto?", "Confirmar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub frmcrearimpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Guardar()
        If Len(Trim(txtimpuesto.Text)) > 0 And Len(Trim(txtporcentaje.Text)) > 0 Then
            ximpuesto.Impuesto = txtimpuesto.Text
            ximpuesto.Porcentaje = txtporcentaje.Text
            Dim resultado As Integer
            resultado = xrepo.insert(ximpuesto)
            If resultado = 0 Then
                MessageBox.Show("El impuesto se creo correctamente", "Información",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
                guardado = True
            Else
                MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Todos los datos son obligatorios", "Falta Informacion",
        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        txtimpuesto.Text = ""
        txtporcentaje.Text = ""
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
    End Sub

    Private Sub txtimpuesto_LostFocus(sender As Object, e As EventArgs) Handles txtimpuesto.LostFocus
        txtimpuesto.Text = StrConv(txtimpuesto.Text, vbProperCase)
    End Sub
End Class
