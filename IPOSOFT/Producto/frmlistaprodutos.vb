Imports MySql.Data.MySqlClient
Public Class frmlistaprodutos
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crearproducto As frmcrearproducto
        crearproducto = New frmcrearproducto
        crearproducto.MdiParent = Me.MdiParent
        crearproducto.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.cerrar()
    End Sub

    Public Function cerrar()
        Me.Dispose()
    End Function

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As frmeditarproducto = New frmeditarproducto
        editar.MdiParent = Me.MdiParent
        editar.Id = Me.Id
        editar.Show()
    End Sub

    Private Sub frmlistaprodutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        Dim datos As MySqlDataReader
        Dim xrepo As repositorioProducto = New repositorioProducto
        If Len(Trim(txtfiltro.Text)) > 0 Then
            datos = xrepo.query(txtfiltro.Text)
        Else
            datos = xrepo.query()
        End If
        Dim fila As Integer
        lvproductos.Items.Clear()

        If datos.HasRows Then
            While datos.Read
                lvproductos.Items.Add(datos(0))
                lvproductos.Items(fila).SubItems.Add(datos(1))
                lvproductos.Items(fila).SubItems.Add(datos(3))
                lvproductos.Items(fila).SubItems.Add(datos(7))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        Cargar()
    End Sub

    Private Sub lvproductos_Click(sender As Object, e As EventArgs) Handles lvproductos.Click
        Id = lvproductos.SelectedItems(0).Text
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarproducto = New frmconsultarproducto
        consultar.Id = Id
        consultar.MdiParent = Me.MdiParent
        consultar.Show()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el producto?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Eliminar()
        End If
    End Sub

    Sub Eliminar()
        Dim resultado As Integer
        Dim xrepo As repositorioProducto = New repositorioProducto
        resultado = xrepo.delete(Id)
        If resultado = 0 Then
            MessageBox.Show("El producgto se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar el producto", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
