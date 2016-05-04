Imports MySql.Data.MySqlClient
Public Class frmzonacliente
    Dim xrepo As zonaRepositorio = New zonaRepositorio
    Private _ID As Integer
    Public Property ID As Integer
        Get
            Return Me._ID
        End Get
        Set(value As Integer)
            Me._ID = value
        End Set
    End Property
    Private Sub frmzonacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Crear()
    End Sub

    Sub Crear()
        Dim crearzona As frmcrearzona
        crearzona = New frmcrearzona
        crearzona.MdiParent = Me.MdiParent
        crearzona.Show()
    End Sub

    Sub Editar()
        Dim editarzona As frmeditarzona
        editarzona = New frmeditarzona
        editarzona.ID = Me.ID
        editarzona.MdiParent = Me.MdiParent
        editarzona.Show()
    End Sub

    Sub Consultar()
        Dim consultarZona As frmconsultarzona
        consultarZona = frmconsultarzona
        consultarZona.ID = Me.ID
        consultarZona.MdiParent = Me.MdiParent
        consultarZona.Show()
    End Sub

    Sub Cargar()
        Dim reader As MySqlDataReader
        Dim xrepo As zonaRepositorio = New zonaRepositorio
        Dim fila As Integer
        Try
            reader = xrepo.query()
            If reader.HasRows Then
                lvzona.Items.Clear()
                While reader.Read
                    lvzona.Items.Add(reader(0))
                    lvzona.Items(fila).SubItems.Add(reader(1))
                    fila = fila + 1
                End While
            End If
            lblcargar.Text = "Carga completa"
            reader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub Eliminar()
        Dim xresultado As Integer
        xresultado = xrepo.delete(Me.ID)
        If xresultado = 0 Then
            MessageBox.Show("La zona se elimino exitosamente", "Eliminacion exitosa",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar()
        Else
            MessageBox.Show("Error al momento de eliminar la zona", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.Cargar()
    End Sub
    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Me.Editar()
    End Sub
    Private Sub lvzona_Click(sender As Object, e As EventArgs) Handles lvzona.Click
        ID = lvzona.SelectedItems(0).Text
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Me.Consultar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("¿Desea eliminar la zona?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Eliminar()
        End If
    End Sub
End Class
