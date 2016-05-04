Public Class frmconsultarzona
    Dim _ID As Integer
    Dim xzona As Zona = New Zona
    Dim xrepo As zonaRepositorio = New zonaRepositorio
    Public Property ID As Integer
        Get
            Return Me._ID
        End Get
        Set(value As Integer)
            Me._ID = value
        End Set
    End Property

    Private Sub frmconsultarzona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Sub Cargar()
        xzona = xrepo.findById(Me.ID)
        txtidzona.Text = xzona.ID
        txtzona.Text = xzona.zona
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cerrar()
    End Sub
End Class
