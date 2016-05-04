Imports MySql.Data.MySqlClient

Public Class frmproveedores
    Dim xrepo As repoitorioProveedor = New repoitorioProveedor
    Dim datos As MySqlDataReader
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        If Len(Trim(txtfiltro.Text)) > 0 Then
            datos = xrepo.query(txtfiltro.Text)
        Else
            datos = xrepo.query
        End If

        lvproveedor.Items.Clear()
        Dim fila As Integer
        If datos.HasRows Then
            While datos.Read
                lvproveedor.Items.Add(datos(0))
                lvproveedor.Items(fila).SubItems.Add(datos(2))
                lvproveedor.Items(fila).SubItems.Add(datos(9))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub lvproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvproveedor.SelectedIndexChanged
        Id = lvproveedor.SelectedItems(0).Text
    End Sub

    Private Sub MetroShell1_Click(sender As Object, e As EventArgs) Handles MetroShell1.Click

    End Sub

    Private Sub frmproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        Cargar()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crear As frmcrearproveedor = New frmcrearproveedor
        crear.MdiParent = Me.MdiParent
        crear.Show()

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As frmeditarproveedor = New frmeditarproveedor
        editar.Id = Id
        editar.MdiParent = Me.MdiParent
        editar.Show()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarproveedor = New frmconsultarproveedor
        consultar.MdiParent = Me.MdiParent
        consultar.Id = Id
        consultar.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el proveedor?", "Confirmar",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub

    Sub Eliminar()
        Dim resultado As Integer
        resultado = xrepo.delete(Id)
        If resultado = 0 Then
            MessageBox.Show("El proveedor se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar el proveedor", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
