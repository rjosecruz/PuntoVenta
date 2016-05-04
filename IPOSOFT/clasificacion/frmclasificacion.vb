Imports MySql.Data.MySqlClient

Public Class frmclasificacion
    Dim xrepo As repoclasificacion = New repoclasificacion
    Dim datos As MySqlDataReader
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim modificar As frmeditarclasificacion = New frmeditarclasificacion
        modificar.MdiParent = Me.MdiParent
        modificar.Id = Me.Id
        modificar.Show()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarcategoria = New frmconsultarcategoria
        consultar.MdiParent = Me.MdiParent
        consultar.Id = Me.Id
        consultar.Show()
    End Sub

    Private Sub lvmarca_Click(sender As Object, e As EventArgs) Handles lvclasificacion.Click
        Id = lvclasificacion.SelectedItems(0).Text
    End Sub

    Private Sub frmclasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        Dim fila As Integer
        If Len(Trim(txtfiltrar.Text)) > 0 Then
            datos = xrepo.query(txtfiltrar.Text)
        Else
            datos = xrepo.query()
        End If

        lvclasificacion.Items.Clear()

        If datos.HasRows Then
            While datos.Read
                lvclasificacion.Items.Add(datos(0))
                lvclasificacion.Items(fila).SubItems.Add(datos(1))
                fila = fila + 1
            End While
        End If
        datos.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crear As frmcrearclasificacion = New frmcrearclasificacion
        crear.MdiParent = Me.MdiParent
        crear.Show()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        Cargar()
    End Sub

    Sub Eliminar()
        Dim resultado As Integer
        resultado = xrepo.delete(Id)
        If resultado = 0 Then
            MessageBox.Show("La clasificacion ha sido eliminada", "Información",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cargar()
        Else
            MessageBox.Show("Error al intentar eliminar los datos", "Falta Informacion",
   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar la clasificacion?", "Confirmar",
 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub
End Class
