Imports MySql.Data.MySqlClient

Public Class frmcompras
    Dim xrepo As repositoriocompras = New repositoriocompras
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

    Private Sub frmcompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crear As frmcrearcompra = frmcrearcompra
        crear.MdiParent = Me.MdiParent
        crear.Show()
    End Sub
    Sub Cargar()
        Dim fila As Integer

        datos = xrepo.Query()
        lvcompras.Items.Clear()

        If datos.HasRows Then
            While datos.Read
                lvcompras.Items.Add(datos(0))
                lvcompras.Items(fila).SubItems.Add(datos(22))
                lvcompras.Items(fila).SubItems.Add(datos(2))
                lvcompras.Items(fila).SubItems.Add(datos(11))
                lvcompras.Items(fila).SubItems.Add(datos(21))

                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As frmeditarcompra = New frmeditarcompra
        editar.MdiParent = Me.MdiParent
        editar.Id = Id
        editar.Show()
    End Sub


    Private Sub lvcompras_Click(sender As Object, e As EventArgs) Handles lvcompras.Click
        Id = lvcompras.SelectedItems(0).Text
    End Sub

    Private Sub lvcompras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvcompras.SelectedIndexChanged

    End Sub
End Class
