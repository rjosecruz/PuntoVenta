Public Class frmconsultaralmacen
    Dim xalmacen As almacen = New almacen
    Dim xrepo As repositorioAlmacen = New repositorioAlmacen

    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmconsultaralmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cargar()
        xalmacen = xrepo.findById(Id)
        txtid.Text = xalmacen.Id
        txtalmacen.Text = xalmacen.Almacen
        txtdireccion.Text = xalmacen.Direccion
        ckestado.Checked = xalmacen.Estado
    End Sub

End Class
