Imports MySql.Data.MySqlClient
Public Class frmlistavendedores
    Private _Id As Integer
    Private xrepo As repoVendedor = New repoVendedor

    Public Property Id As Integer
        Get
            Return Me._Id
        End Get
        Set(value As Integer)
            Me._Id = value
        End Set
    End Property
    Private Sub MetroTabItem1_Click(sender As Object, e As EventArgs) Handles MetroTabItem1.Click

    End Sub

    Private Sub frmlistavendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        Try
            Dim datos As MySqlDataReader
            datos = xrepo.query
            Dim fila As Integer = 0
            lvlista.Items.Clear()

            If datos.HasRows Then
                While datos.Read
                    lvlista.Items.Add(datos(0))
                    lvlista.Items(fila).SubItems.Add(datos(1))
                    lvlista.Items(fila).SubItems.Add(datos(3))
                    fila = fila + 1
                End While
            End If
            datos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Eliminar()
        Dim xresultado As Integer
        xresultado = xrepo.delete(Me.Id)
        If xresultado = 0 Then
            MessageBox.Show("El vendedor se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar la zona", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub



    Private Sub lvlista_Click(sender As Object, e As EventArgs) Handles lvlista.Click
        Me.Id = lvlista.SelectedItems(0).Text

    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crearvendedor As frmcrearvendedor
        crearvendedor = New frmcrearvendedor
        crearvendedor.MdiParent = Me.MdiParent
        crearvendedor.Show()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.Cargar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el vendedor?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As frmeditarvendedor = New frmeditarvendedor
        editar.MdiParent = Me.MdiParent
        editar.Id = Me.Id
        editar.Show()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarvendedor = New frmconsultarvendedor
        consultar.MdiParent = Me.MdiParent
        consultar.Id = Me.Id
        consultar.Show()

    End Sub
End Class
