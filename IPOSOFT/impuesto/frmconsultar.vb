Public Class frmconsultar
    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim xrepo As repoimpuesto = New repoimpuesto
    Dim ximpuesto As impuesto = New impuesto
    Private Sub frmconsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub
    Sub Cargar()
        ximpuesto = xrepo.findById(Id)
        txtid.Text = ximpuesto.Id
        txtimpuesto.Text = ximpuesto.Impuesto
        txtporcentaje.Text = ximpuesto.Porcentaje
        ckhabilitado.Checked = ximpuesto.Estado
    End Sub
End Class
