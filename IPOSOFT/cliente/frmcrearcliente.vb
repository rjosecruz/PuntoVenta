Imports MySql.Data.MySqlClient
Public Class frmcrearcliente
    Private _id As Integer
    Dim xrepo As repocliente = New repocliente
    Dim xcliente As cliente = New cliente

    Dim xrepozona As zonaRepositorio = New zonaRepositorio
    Dim zonareader As MySqlDataReader

    Dim xrepovendedor As repoVendedor = New repoVendedor
    Dim vendedorreader As MySqlDataReader

    Dim guardado As Boolean = False

    Public Property ID As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmcrearcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarZonas()
        CargarVendedores()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If guardado = True Then
            Me.Cerrar()
        Else
            If MessageBox.Show("¿Cancelar la creacion del cliente?", "Confirmar",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cerrar()
            End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtlimitecredito.TextChanged

    End Sub

    Sub CargarVendedores()
        cmbvendedor.ValueMember = "_ID"
        cmbvendedor.DisplayMember = "nombre"
        cmbvendedor.DataSource = GetVendedorItems()
    End Sub

    Sub CargarZonas()
        cmbzona.ValueMember = "_ID"
        cmbzona.DisplayMember = "nombre"
        cmbzona.DataSource = GetZonaItems()
    End Sub


    Function GetZonaItems() As List(Of Zona)
        Dim zonaItems = New List(Of Zona)
        zonareader = xrepozona.query
        If zonareader.HasRows = True Then
            While zonareader.Read()
                zonaItems.Add(New Zona(zonareader(0), zonareader(1)))
            End While
            zonareader.Close()
        End If
        Return zonaItems
    End Function

    Private Sub cmbzona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbzona.SelectedIndexChanged
        Dim oItems As Zona = CType(cmbzona.SelectedItem, Zona)
        xcliente.Idzona = oItems.ID
    End Sub
    Function GetVendedorItems() As List(Of vendedor)
        Dim vendedorItems = New List(Of vendedor)
        vendedorreader = xrepovendedor.query

        If vendedorreader.HasRows = True Then
            While vendedorreader.Read()
                vendedorItems.Add(New vendedor(vendedorreader(0), vendedorreader(1)))
            End While
            vendedorreader.Close()
        End If
        Return vendedorItems
    End Function

    Private Sub cmbvendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvendedor.SelectedIndexChanged
        Dim oItems As vendedor = CType(cmbvendedor.SelectedItem, vendedor)
        xcliente.Idvendedor = oItems.Id
    End Sub

    Sub Guardar()
        Dim oItems As vendedor = CType(cmbvendedor.SelectedItem, vendedor)
        Dim oItemsz As Zona = CType(cmbzona.SelectedItem, Zona)

        xcliente.Rtn = Trim(txtrtn.Text)
        xcliente.Nombre = Trim(txtnombre.Text)
        xcliente.Direccion = Trim(txtdireccion.Text)
        xcliente.Idvendedor = oItems.Id
        xcliente.Idzona = oItemsz.ID
        xcliente.Mail = txtmail.Text
        xcliente.Contacto = txtcontacto.Text
        xcliente.Telefono = txttelefono.Text
        xcliente.Movil = txtmovil.Text
        xcliente.Limitecredito = txtlimitecredito.Text
        xcliente.Saldo = txtsaldo.Text
        xcliente.Diascredito = txtdiascredito.Text
        xcliente.Estado = ckestado.Checked
        xcliente.Latitud = txtlatitud.Text
        xcliente.Longitud = txtlongitud.Text
        Dim resultado As Integer
        resultado = xrepo.insert(xcliente)
        If resultado = 0 Then
            MessageBox.Show("El cliente se creo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False
            guardado = True
        Else
            MessageBox.Show("Error al momento de crear el cliente", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        txtnombre.Text = StrConv(txtnombre.Text, vbProperCase)
    End Sub

    Private Sub txtdireccion_LostFocus(sender As Object, e As EventArgs) Handles txtdireccion.LostFocus
        txtdireccion.Text = StrConv(txtdireccion.Text, vbProperCase)
    End Sub

    Private Sub txtcontacto_LostFocus(sender As Object, e As EventArgs) Handles txtcontacto.LostFocus
        txtcontacto.Text = StrConv(txtcontacto.Text, vbProperCase)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtrtn.Text)) > 0 And Len(Trim(txtnombre.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("Faltan el RTN y/o Nombre del cliente, favor completelos", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
