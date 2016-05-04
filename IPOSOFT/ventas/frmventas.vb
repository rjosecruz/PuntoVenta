Imports MySql.Data.MySqlClient

Public Class frmventas
    Public _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btnpagos.Click
        Pagar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        Dim xrepo As repositorioventa = New repositorioventa
        Dim datos As MySqlDataReader
        Dim fila As Integer
        If Len(Trim(txtfiltro.Text)) > 0 Then
            datos = xrepo.Query(txtfiltro.Text)
        Else
            datos = xrepo.Query
        End If
        If datos.HasRows Then
            While datos.Read
                lvfacturas.Items.Add(datos(0))
                lvfacturas.Items(fila).SubItems.Add(datos(1))
                lvfacturas.Items(fila).SubItems.Add(datos(2))
                lvfacturas.Items(fila).SubItems.Add(datos(3))
                lvfacturas.Items(fila).SubItems.Add(datos(4))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub frmventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub lvproveedor_Click(sender As Object, e As EventArgs) Handles lvfacturas.Click
        Id = lvfacturas.SelectedItems(0).Text
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim facturar As frmcrearfactura = New frmcrearfactura
        facturar.MdiParent = Me.MdiParent
        facturar.Show()
    End Sub

    Private Sub btncerrar_Click_1(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Pagar()
        Dim pagos As frmpagosfactura = New frmpagosfactura
        pagos.Id = Id
        pagos.ShowDialog()
    End Sub

    Private Sub lvfacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvfacturas.SelectedIndexChanged

    End Sub
End Class
