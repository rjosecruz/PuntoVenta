Imports MySql.Data.MySqlClient
Public Class frmalmacenes
    Dim datos As MySqlDataReader
    Dim xrepo As repositorioAlmacen = New repositorioAlmacen
    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmalmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()

        If Len(Trim(txtfiltrar.Text)) > 0 Then
            datos = xrepo.query(txtfiltrar.Text)
        Else
            datos = xrepo.query
        End If

        Dim fila As Integer
        lvalmacen.Items.Clear()
        If datos.HasRows Then
            While datos.Read
                lvalmacen.Items.Add(datos(0))
                lvalmacen.Items(fila).SubItems.Add(datos(1))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cerrar()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim crear As frmcrearalmacen = New frmcrearalmacen
        crear.MdiParent = Me.MdiParent
        crear.Show()
    End Sub
    Private Sub lvclasificacion_Click(sender As Object, e As EventArgs) Handles lvalmacen.Click
        Id = lvalmacen.SelectedItems(0).Text
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        Cargar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cargar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim consultar As frmconsultaralmacen = New frmconsultaralmacen
        consultar.MdiParent = Me.MdiParent
        consultar.Id = Id
        consultar.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim editar As frmmodificaralmacen = New frmmodificaralmacen
        editar.MdiParent = Me.MdiParent
        editar.Id = Id
        editar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("¿Desea eliminar el almacen?", "Confirmar",
 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub

    Sub Eliminar()
        Dim resultado As Integer
        resultado = xrepo.delete(Id)
        If resultado = 0 Then
            MessageBox.Show("El almacen ha sido eliminado", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cargar()
        Else
            MessageBox.Show("Error al intentar eliminar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
