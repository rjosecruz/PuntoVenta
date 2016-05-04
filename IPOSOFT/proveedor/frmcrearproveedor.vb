Public Class frmcrearproveedor
    Dim guardado As Boolean = False
    Dim xrepo As repoitorioProveedor = New repoitorioProveedor
    Dim xproveedor As proveedor = New proveedor
    Private Sub frmcrearproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion del proveedor?", "Confirmar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtnombre.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Escriba el nombre del proveedor", "Información incompleta",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Sub Guardar()
        xproveedor.Codigo = txtcodigo.Text
        xproveedor.Nombre = txtnombre.Text
        xproveedor.Representante = txtrepresentante.Text
        xproveedor.Direccion = txtdireccion.Text
        xproveedor.Telefono = txttelefono.Text
        xproveedor.Mail = txtmail.Text
        xproveedor.Pais = txtpais.Text
        xproveedor.Saldo = txtsaldo.Value
        xproveedor.Estado = ckestado.Checked
        Dim resultado As Integer
        resultado = xrepo.insert(xproveedor)
        If resultado = 0 Then
            MessageBox.Show("El proveedor se creo correctamente", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            guardado = True
        Else
            MessageBox.Show("Error al intentar guardar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub
    Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtrepresentante.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtmail.Text = ""
        txtpais.Text = ""
        txtsaldo.Value = 0
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        txtnombre.Text = StrConv(txtnombre.Text, vbProperCase)
    End Sub

    Private Sub txtrepresentante_TextChanged(sender As Object, e As EventArgs) Handles txtrepresentante.TextChanged

    End Sub

    Private Sub txtrepresentante_LostFocus(sender As Object, e As EventArgs) Handles txtrepresentante.LostFocus
        txtrepresentante.Text = StrConv(txtrepresentante.Text, vbProperCase)
    End Sub
End Class
