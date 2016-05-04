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
            If datos.HasRows Then
                While datos.Read
                    lvlista.Items.Add(datos(0))
                    lvlista.Items(fila).SubItems.Add(datos(1))
                    lvlista.Items(fila).SubItems.Add(datos(3))
                End While
            End If
            datos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
End Class
