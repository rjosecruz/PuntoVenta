Public Class frmconsultarmarca
    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim xmarca As marca = New marca
    Dim xrepo As repomarca = New repomarca
    Private Sub frmconsultarmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        xmarca = xrepo.findById(Id)
        txtid.Text = xmarca.Id
        txtmarca.Text = xmarca.Marca
        ckestado.Checked = xmarca.Estado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub
End Class
