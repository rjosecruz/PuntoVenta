Imports MySql.Data.MySqlClient
Public Class frmmarcas
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
    Private Sub frmmarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub

    Sub Cargar()
        Dim reader As MySqlDataReader
        If Len(Trim(txtfiltrar.Text)) > 0 Then
            reader = xrepo.query(txtfiltrar.Text)
        Else
            reader = xrepo.query
        End If

        Dim contador As Integer
        lvclasificacion.Items.Clear()

        If reader.HasRows Then
            While reader.Read
                lvclasificacion.Items.Add(reader(0))
                lvclasificacion.Items(contador).SubItems.Add(reader(1))
                contador = contador + 1
            End While
        End If
        reader.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim crear As frmcrearmarca = New frmcrearmarca
        crear.MdiParent = Me.MdiParent
        crear.Show()
    End Sub
    Private Sub lvmarca_Click(sender As Object, e As EventArgs) Handles lvclasificacion.Click
        Id = lvclasificacion.SelectedItems(0).Text
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim editar As frmeditarmarca = New frmeditarmarca
        editar.MdiParent = Me.MdiParent
        editar.Id = Id
        editar.Show()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Cargar()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim consultar As frmconsultarmarca
        consultar = New frmconsultarmarca
        consultar.Id = Id
        consultar.MdiParent = Me.MdiParent
        consultar.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar el vendedor?", "Confirmar",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub
    Sub Eliminar()
        Dim resultado As Integer
        resultado = xrepo.delete(Id)
        If resultado = 0 Then
            MessageBox.Show("La marca se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar la marca", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        Cargar()
    End Sub

    Private Sub lvclasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvclasificacion.SelectedIndexChanged

    End Sub
End Class
