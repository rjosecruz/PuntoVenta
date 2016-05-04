Imports MySql.Data.MySqlClient
Public Class frmconsultarcliente
    Dim _xid As Integer
    Dim xcliente As cliente = New cliente
    Dim xrepo As repocliente = New repocliente

    Dim xrepozona As zonaRepositorio = New zonaRepositorio
    Dim zonareader As MySqlDataReader

    Dim xrepovendedor As repoVendedor = New repoVendedor
    Dim vendedorreader As MySqlDataReader
    Public Property XID As Integer
        Get
            Return _xid
        End Get
        Set(value As Integer)
            _xid = value
        End Set
    End Property
    Private Sub frmconsultarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVendedores()
        CargarZonas()
        Cargar()
    End Sub
    Sub Cargar()
        xcliente = xrepo.findById(XID)
        txtid.Text = xcliente.Id
        txtrtn.Text = xcliente.Rtn
        txtnombre.Text = xcliente.Nombre
        txtdireccion.Text = xcliente.Direccion
        cmbvendedor.Text = xcliente.xvendedor.Nombre
        cmbzona.Text = xcliente.xzona.zona
        txtmail.Text = xcliente.Mail
        txtcontacto.Text = xcliente.Contacto
        txttelefono.Text = xcliente.Telefono
        txtmovil.Text = xcliente.Movil
        txtlimitecredito.Text = xcliente.Limitecredito
        txtsaldo.Text = xcliente.Saldo
        txtdiascredito.Text = xcliente.Diascredito
        ckestado.Checked = xcliente.Estado
        txtlongitud.Text = xcliente.Longitud
        txtlatitud.Text = xcliente.Latitud

    End Sub
    Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub CargarZonas()
        cmbzona.ValueMember = "_ID"
        cmbzona.DisplayMember = "nombre"
        cmbzona.DataSource = GetZonaItems()
    End Sub

    Sub CargarVendedores()
        cmbvendedor.ValueMember = "_ID"
        cmbvendedor.DisplayMember = "nombre"
        cmbvendedor.DataSource = GetVendedorItems()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cerrar()
    End Sub
End Class
