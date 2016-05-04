Imports MySql.Data.MySqlClient

Public Class frmeditarproducto
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
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Cerrar()
    End Sub

    Public Function Cerrar()
        Me.Dispose()
    End Function

    Private Sub frmeditarproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImpuesto()
        CargarMarcas()
        CargarClasificacion()
        Cargar()
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

    Sub Actualizar()
        Dim xrepositorioalmacen As repositorioProductoAlmacen = New repositorioProductoAlmacen
        Dim oItemmarca As marca = CType(cmbmarca.SelectedItem, marca)
        Dim oItemsclasificacion As clasificacion = CType(cmbclasificacion.SelectedItem, clasificacion)
        Dim oItemsimpuesto As impuesto = CType(cmbimpuesto.SelectedItem, impuesto)
        Dim resultado As Integer
        xproduto.CodigoBarras = txtcodigo.Text
        xproduto.CodigoSap = txtcodigosap.Text
        xproduto.Descripcion = txtdescripcion.Text
        xproduto.Clasificacion = oItemsclasificacion.Id
        xproduto.Marca = oItemmarca.Id
        xproduto.Impuesto = oItemsimpuesto.Id
        xproduto.Precio = txtprecio.Value
        xproduto.Estado = ckestado.Checked
        xproduto.UxC = txtuxcaja.Value
        xproduto.Costopromedio = costopromedio.Value
        xproduto.TiempoReabastecimiento = txttiemporeabastecimiento.Value
        xproduto.SemanasEnMano = txtsemanasenmano.Value
        xproduto.ConsumoPromedio = txtconsumopromedio.Value
        xproduto.CantidadMinima = txtcantidadminima.Value
        xproduto.CantidadMaxima = txtcantidadmaxima.Value
        xproduto.PuntoReorden = txtreorden.Value
        resultado = xrepo.update(xproduto)

        If resultado = 0 Then
            MessageBox.Show("El producto se actualizo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False

        Else
            MessageBox.Show("Error al momento de actualizar el producto", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtcodigo.Text)) > 0 And Len(Trim(txtdescripcion.Text)) > 0 And Len(Trim(txtprecio.Text)) > 0 Then
            Actualizar()
        Else
            MessageBox.Show("La descripcion, el precio y el codigo del producto son obligatorios, favor completelos", "Error",
  MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtdescripcion_LostFocus(sender As Object, e As EventArgs) Handles txtdescripcion.LostFocus
        txtdescripcion.Text = StrConv(txtdescripcion.Text, vbProperCase)
    End Sub
End Class
