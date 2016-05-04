Option Strict Off
Imports MySql.Data.MySqlClient

Public Class frmbuscarproveedor
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Dim _origen As Integer
    Public Property Origen As Integer
        Get
            Return _origen
        End Get
        Set(value As Integer)
            _origen = value
        End Set
    End Property
    Dim _objectorigen As Object
    Public Property ObjectOrigen As Object
        Get
            Return _objectorigen
        End Get
        Set(value As Object)
            _objectorigen = value
        End Set
    End Property


    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Cerrar()

        Dispose()
    End Sub

    Private Sub frmbuscarproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cargar()
        Dim xproveedor As proveedor = New proveedor
        Dim xrepo As repoitorioProveedor = New repoitorioProveedor
        Dim datos As MySqlDataReader
        Dim fila As Integer
        lvcproveedor.Items.Clear()

        If Len(Trim(txtbuscar.Text)) > 0 Then
            datos = xrepo.query(txtbuscar.Text)
        Else
            datos = xrepo.query()
        End If
        If datos.HasRows Then
            While datos.Read
                lvcproveedor.Items.Add(datos(0))
                lvcproveedor.Items(fila).SubItems.Add(datos(2))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Cargar()
    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        If (TypeOf ObjectOrigen Is frmcrearcompra) Then
            Dim miobjeto As Object = New Object
            miobjeto = CType(ObjectOrigen, frmcrearcompra)
            miobjeto.Idproveedor = Id
            Me.Dispose()

        End If
    End Sub



    Private Sub lvcproveedor_Click(sender As Object, e As EventArgs) Handles lvcproveedor.Click
        Id = lvcproveedor.SelectedItems(0).Text
    End Sub
End Class
