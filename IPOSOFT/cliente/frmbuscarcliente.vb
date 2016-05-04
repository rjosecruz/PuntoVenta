Imports MySql.Data.MySqlClient

Public Class frmbuscarcliente
    Dim xcliente As cliente = New cliente
    Dim xrepo As repocliente = New repocliente
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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
        Me.Dispose()
    End Sub

    Sub Cargar()

        lvcliente.Items.Clear()
        Dim datos As MySqlDataReader
        If Len(Trim(txtbuscar.Text)) > 0 Then
            datos = xrepo.query(txtbuscar.Text)
        Else
            datos = xrepo.query
        End If
        Dim fila As Integer
        If datos.HasRows Then
            While datos.Read
                lvcliente.Items.Add(datos(0))
                lvcliente.Items(fila).SubItems.Add(datos(2))
                fila = fila + 1
            End While
        End If
        datos.Close()

    End Sub

    Private Sub frmbuscarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Cargar()
    End Sub

    Private Sub lvcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvcliente.SelectedIndexChanged

    End Sub

    Private Sub MetroTabPanel2_Click(sender As Object, e As EventArgs) Handles MetroTabPanel2.Click

    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Procesar()
    End Sub
    Sub Procesar()

        If (TypeOf ObjectOrigen Is frmcrearfactura) Then
            Dim miobjeto As Object = New Object
            miobjeto = CType(ObjectOrigen, frmcrearfactura)
            miobjeto.IdCliente = Id
            Me.Dispose()
        End If

    End Sub

    Private Sub lvcliente_Click(sender As Object, e As EventArgs) Handles lvcliente.Click
        Id = lvcliente.SelectedItems(0).Text
    End Sub
End Class
