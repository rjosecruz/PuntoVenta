Public Class frmcrearalmacen
    Dim guardado As Boolean = False
    Dim xalmacen As almacen = New almacen
    Dim xrepo As repositorioAlmacen = New repositorioAlmacen
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion del almacen?", "Confirmar",
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
        txtalmacen.Text = ""
        txtdireccion.Text = ""
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtalmacen.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Escriba la clasificacion", "Información incompleta",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub Guardar()
        Dim resultado As Integer
        xalmacen.Almacen = txtalmacen.Text
        xalmacen.Direccion = txtdireccion.Text
        xalmacen.Estado = True
        resultado = xrepo.insert(xalmacen)
        If resultado = 0 Then
            MessageBox.Show("El almacen se creo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            guardado = True
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frmcrearalmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtalmacen_LostFocus(sender As Object, e As EventArgs) Handles txtalmacen.LostFocus
        txtalmacen.Text = StrConv(txtalmacen.Text, vbProperCase)
    End Sub
End Class
