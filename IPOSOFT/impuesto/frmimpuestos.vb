Imports MySql.Data.MySqlClient
Public Class frmimpuestos
    Private _id As Integer
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmimpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim edita As frmeditarimpuesto = New frmeditarimpuesto
        edita.MdiParent = Me.MdiParent
        edita.Id = id
        edita.Show()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultar = New frmconsultar
        consultar.Id = id
        consultar.MdiParent = Me.MdiParent
        consultar.Show()
    End Sub
    Sub Cargar()
        Dim datos As MySqlDataReader
        Dim xrepo As repoimpuesto = New repoimpuesto
        datos = xrepo.query()
        Dim contador As Integer
        lvimpuesto.Items.Clear()

        If datos.HasRows Then
            While datos.Read
                lvimpuesto.Items.Add(datos(0))
                lvimpuesto.Items(contador).SubItems.Add(datos(1))
                lvimpuesto.Items(contador).SubItems.Add(datos(2))
                contador = contador + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub lvimpuesto_Click(sender As Object, e As EventArgs) Handles lvimpuesto.Click
        id = lvimpuesto.SelectedItems(0).Text
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crear As frmcrearimpuesto = New frmcrearimpuesto
        crear.MdiParent = Me.MdiParent
        crear.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el vendedor?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub

    Sub Eliminar()
        Dim xrepo As repoimpuesto = New repoimpuesto
        Dim xresultado As Integer
        xresultado = xrepo.delete(Me.id)
        If xresultado = 0 Then
            MessageBox.Show("El impuesto se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar el impuesto", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
