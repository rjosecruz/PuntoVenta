Imports MySql.Data.MySqlClient

Public Class frmbuscarproducto
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

    Dim datos As MySqlDataReader
    Dim xrepo As repositorioProducto = New repositorioProducto
    Dim xproducto As producto = New producto
    Dim _id As Integer
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Dispose()
    End Sub
    Sub Cargar()
        Dim fila As Integer
        If Len(Trim(txtbuscar.Text)) > 0 Then
            datos = xrepo.query(txtbuscar.Text)
        Else
            datos = xrepo.query
        End If
        lvbuscarproducto.Items.Clear()

        If datos.HasRows Then
            While datos.Read
                lvbuscarproducto.Items.Add(datos(0))
                lvbuscarproducto.Items(fila).SubItems.Add(datos(1))
                lvbuscarproducto.Items(fila).SubItems.Add(datos(3))
                lvbuscarproducto.Items(fila).SubItems.Add(datos(7))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Cargar()
    End Sub
    Private Sub frmbuscarproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub lvbuscarproducto_Click(sender As Object, e As EventArgs) Handles lvbuscarproducto.Click
        Id = lvbuscarproducto.SelectedItems(0).Text
    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Procesar()

    End Sub
    Sub Procesar()
        If (TypeOf ObjectOrigen Is frmcrearcompra) Then
            Dim miobjeto As Object = New Object
            miobjeto = CType(ObjectOrigen, frmcrearcompra)
            miobjeto.IdProducto = Id
            Me.Dispose()
        End If
        If (TypeOf ObjectOrigen Is frmcrearfactura) Then
            Dim miobjeto As Object = New Object
            miobjeto = CType(ObjectOrigen, frmcrearfactura)
            miobjeto.IdProducto = Id
            Me.Dispose()
        End If

    End Sub
End Class
