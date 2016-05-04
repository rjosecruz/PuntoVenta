Public Class frmcrearvendedor
    Dim guardado As Boolean = False
    Dim xrepo As repoVendedor = New repoVendedor
    Dim xvendedor As vendedor = New vendedor
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion del vendedor?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Sub Guardar()
        Dim resultado As Integer
        xvendedor.Direccion = txtdireccion.Text
        xvendedor.Nombre = txtnombre.Text
        xvendedor.Estado = ckestado.Checked
        xvendedor.Telefono = txttelefono.Text
        resultado = xrepo.insert(xvendedor)
        If resultado = 0 Then
            MessageBox.Show("El vendedor se creo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False
            guardado = True
        Else
            MessageBox.Show("Error al momento de crear el vendedor", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtdireccion.Text)) > 0 And Len(Trim(txtnombre.Text)) > 0 And Len(Trim(txttelefono.Text)) > 0 Then

            Guardar()
        Else
            MessageBox.Show("Error al momento de crear la zona,debe llenar todos los campos", "Error",
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        txtnombre.Text = StrConv(txtnombre.Text, vbProperCase)
    End Sub

    Private Sub txtdireccion_LostFocus(sender As Object, e As EventArgs) Handles txtdireccion.LostFocus
        txtdireccion.Text = StrConv(txtdireccion.Text, vbProperCase)
    End Sub

    Private Sub frmcrearvendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
