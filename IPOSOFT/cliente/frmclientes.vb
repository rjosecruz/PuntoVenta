Imports MySql.Data.MySqlClient
Public Class frmclientes
    Dim _xid As Integer
    Dim xrepo As repocliente = New repocliente
    Property Idcliente As Integer
        Get
            Return Me._xid
        End Get
        Set(value As Integer)
            _xid = value
        End Set
    End Property
    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crearcliente As frmcrearcliente = New frmcrearcliente
        crearcliente.MdiParent = Me.MdiParent
        crearcliente.Show()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        Dim datos As MySqlDataReader
        Dim xrepo As repocliente = New repocliente

        If Len(Trim(txtbuscar.Text)) > 0 Then
            datos = xrepo.query(txtbuscar.Text)
        Else
            datos = xrepo.query()
        End If
        Dim fila As Integer
        lvcliente.Items.Clear()
        If datos.HasRows Then


            While datos.Read
                lvcliente.Items.Add(datos(0))
                lvcliente.Items(fila).SubItems.Add(datos(2))
                lvcliente.Items(fila).SubItems.Add(datos(3))
                lvcliente.Items(fila).SubItems.Add(datos(11))
                lvcliente.Items(fila).SubItems.Add(datos(6))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub


    Private Sub lvcliente_Click(sender As Object, e As EventArgs) Handles lvcliente.Click
        Idcliente = lvcliente.SelectedItems(0).Text
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editarcliente As frmeditarcliente = New frmeditarcliente
        editarcliente.MdiParent = Me.MdiParent
        editarcliente.XID = Me.Idcliente
        editarcliente.Show()

    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarcliente = New frmconsultarcliente
        consultar.MdiParent = Me.MdiParent
        consultar.XID = Me.Idcliente
        consultar.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el cliente?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub
    Sub Eliminar()
        Dim resultado As Integer
        resultado = xrepo.delete(Me.Idcliente)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Cargar()
    End Sub
End Class
