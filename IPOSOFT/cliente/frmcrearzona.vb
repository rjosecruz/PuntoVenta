Public Class frmcrearzona
    Dim xzona As Zona
    Dim guardado As Boolean = False
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion de la zona?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.cerrar()
            End If
        End If

    End Sub
    Public Function cerrar()
        Me.Dispose()
    End Function

    Private Sub frmcrearzona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtzona.Focus()
    End Sub

    Sub Limpiar()
        txtzona.Text = ""
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Me.Limpiar()
    End Sub

    Sub Guardar()
        Dim xrepo As zonaRepositorio
        xrepo = New zonaRepositorio
        xzona = New Zona
        Dim resultado As Integer
        Try
            xzona.zona = txtzona.Text
            resultado = xrepo.insert(xzona)
            If resultado = 0 Then
                MessageBox.Show("La zona se creo exitosamente", "Creacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnguardar.Enabled = False
                guardado = True
            Else
                MessageBox.Show("Error al momento de crear la zona", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtzona.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Error al momento de crear la zona", "Error",
       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MetroShell1_Click(sender As Object, e As EventArgs) Handles MetroShell1.Click

    End Sub

    Private Sub txtzona_TextChanged(sender As Object, e As EventArgs) Handles txtzona.TextChanged

    End Sub

    Private Sub txtzona_LostFocus(sender As Object, e As EventArgs) Handles txtzona.LostFocus
        txtzona.Text = StrConv(txtzona.Text, vbProperCase)
    End Sub
End Class
