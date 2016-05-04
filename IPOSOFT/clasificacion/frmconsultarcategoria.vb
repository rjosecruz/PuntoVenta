Public Class frmconsultarcategoria
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmconsultarcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Sub Cargar()
        Dim xrepo As repoclasificacion = New repoclasificacion
        Dim xclasificacion As clasificacion = New clasificacion
        xclasificacion = xrepo.findById(Id)
        txtid.Text = xclasificacion.Id
        txtclasificacion.Text = xclasificacion.Clasificacion
        ckestado.Checked = xclasificacion.Estado
    End Sub
End Class
