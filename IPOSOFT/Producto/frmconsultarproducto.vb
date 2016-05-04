Imports MySql.Data.MySqlClient

Public Class frmconsultarproducto
    Dim xrepo As repositorioProducto = New repositorioProducto
    Dim xproduto As producto = New producto
    Dim datos As MySqlDataReader
    Dim xrepoexistencia As repositorioProductoAlmacen = New repositorioProductoAlmacen
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private Sub frmconsultarproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImpuesto()
        CargarMarcas()
        CargarClasificacion()
        Cargar()
    End Sub
    Public Sub Cerrar()
        Me.Dispose()
    End Sub

    Sub Cargar()
        xproduto = xrepo.findById(Id)
        xproduto.getExtras()
        txtid.Text = xproduto.Id
        txtcodigo.Text = xproduto.CodigoBarras
        txtcodigosap.Text = xproduto.CodigoSap
        txtdescripcion.Text = xproduto.Descripcion
        cmbclasificacion.Text = xproduto.xClasificacion.Clasificacion
        cmbimpuesto.Text = xproduto.xImpuesto.Impuesto
        cmbmarca.Text = xproduto.xMarca.Marca
        txtprecio.Value = xproduto.Precio
        ckestado.Checked = xproduto.Estado
        txtuxcaja.Text = xproduto.UxC
        txtconsumopromedio.Value = xproduto.Costopromedio
        txttiemporeabastecimiento.Value = xproduto.TiempoReabastecimiento
        txtsemanasenmano.Value = xproduto.SemanasEnMano
        txtconsumopromedio.Value = xproduto.ConsumoPromedio
        txtcantidadminima.Value = xproduto.CantidadMinima
        txtcantidadmaxima.Value = xproduto.CantidadMaxima
        txtreorden.Value = xproduto.PuntoReorden
        txtexistencia.Value = xproduto.Existencia
        datos = xrepoexistencia.Query(xproduto.Id)
        Dim acumlado_existencia As Double
        If datos.HasRows Then
            lvexistencia.Items.Clear()
            Dim fila As Integer
            While datos.Read
                lvexistencia.Items.Add(datos(0))
                lvexistencia.Items(fila).SubItems.Add(datos(1))
                lvexistencia.Items(fila).SubItems.Add(datos(4))
                fila = fila + 1
                acumlado_existencia = acumlado_existencia + datos(4)
            End While
        End If
        xproduto.Existencia = acumlado_existencia
        datos.Close()
        txtexistencia.Text = xproduto.Existencia
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub
    Function GetimpuestoItems() As List(Of impuesto)
        Dim impuestoItems = New List(Of impuesto)
        Dim xrepo As repoimpuesto = New repoimpuesto
        datos = xrepo.query
        If datos.HasRows = True Then
            While datos.Read()
                impuestoItems.Add(New impuesto(datos(0), datos(1)))
            End While
            datos.Close()
        End If
        Return impuestoItems
    End Function
    Function GetmarcaItems() As List(Of marca)
        Dim marcaItems = New List(Of marca)
        Dim xrepo As repomarca = New repomarca
        datos = xrepo.query
        If datos.HasRows = True Then
            While datos.Read()
                marcaItems.Add(New marca(datos(0), datos(1)))
            End While
            datos.Close()
        End If
        Return marcaItems
    End Function
    Function GetclasificacionItems() As List(Of clasificacion)
        Dim clasificacionItems = New List(Of clasificacion)
        Dim xrepo As repoclasificacion = New repoclasificacion
        datos = xrepo.query
        If datos.HasRows = True Then
            While datos.Read()
                clasificacionItems.Add(New clasificacion(datos(0), datos(1)))
            End While
            datos.Close()
        End If
        Return clasificacionItems
    End Function
    Sub CargarImpuesto()
        cmbimpuesto.ValueMember = "_ID"
        cmbimpuesto.DisplayMember = "descripcion"
        cmbimpuesto.DataSource = GetimpuestoItems()
    End Sub
    Sub CargarMarcas()
        cmbmarca.ValueMember = "_ID"
        cmbmarca.DisplayMember = "marca"
        cmbmarca.DataSource = GetmarcaItems()
    End Sub
    Sub CargarClasificacion()
        cmbclasificacion.ValueMember = "_ID"
        cmbclasificacion.DisplayMember = "descripcion"
        cmbclasificacion.DataSource = GetclasificacionItems()
    End Sub
End Class
