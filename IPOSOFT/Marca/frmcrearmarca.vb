Public Class frmcrearmarca
    Dim guardado As Boolean = False
    Dim xmarca As marca = New marca
    Dim xrepor As repomarca = New repomarca
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

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
    End Sub
    Sub Limpiar()
        txtmarca.Text = ""
    End Sub
    Sub Guardar()
        Dim resultado As Integer
        xmarca.Marca = txtmarca.Text
        resultado = xrepor.insert(xmarca)
        If resultado = 0 Then
            MessageBox.Show("La marca se creo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            guardado = True
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtmarca.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Escriba la marca", "Información incompleta",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtmarca_LostFocus(sender As Object, e As EventArgs) Handles txtmarca.LostFocus
        txtmarca.Text = StrConv(txtmarca.Text, vbProperCase)
    End Sub

    Private Sub MetroTabPanel1_Click(sender As Object, e As EventArgs) Handles MetroTabPanel1.Click

    End Sub

    Private Sub frmcrearmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
