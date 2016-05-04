Imports MySql.Data.MySqlClient
Public Class frmcrearproducto
    Dim datos As MySqlDataReader
    Dim xrepoProducto As repositorioProducto = New repositorioProducto
    Dim xproducto As producto = New producto
    Dim guardado As Boolean = False

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Cerrar()
    End Sub

    Sub Cerrar()
        Me.Dispose()
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged

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

    Private Sub frmcrearproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarImpuesto()
        CargarMarcas()
        CargarClasificacion()
    End Sub

    Sub Guardar()
        Dim xrepositorioalmacen As repositorioProductoAlmacen = New repositorioProductoAlmacen
        Dim oItemmarca As marca = CType(cmbmarca.SelectedItem, marca)
        Dim oItemsclasificacion As clasificacion = CType(cmbclasificacion.SelectedItem, clasificacion)
        Dim oItemsimpuesto As impuesto = CType(cmbimpuesto.SelectedItem, impuesto)
        Dim resultado As Integer
        xproducto.CodigoBarras = txtcodigo.Text
        xproducto.CodigoSap = txtcodigosap.Text
        xproducto.Descripcion = txtdescripcion.Text
        xproducto.Clasificacion = oItemsclasificacion.Id
        xproducto.Marca = oItemmarca.Id
        xproducto.Impuesto = oItemsimpuesto.Id
        xproducto.Precio = txtprecio.Value
        xproducto.Estado = ckestado.Checked
        xproducto.UxC = txtuxcaja.Value
        xproducto.Costopromedio = costopromedio.Value
        xproducto.TiempoReabastecimiento = txttiemporeabastecimiento.Value
        xproducto.SemanasEnMano = txtsemanasenmano.Value
        xproducto.ConsumoPromedio = txtconsumopromedio.Value
        xproducto.CantidadMinima = txtcantidadminima.Value
        xproducto.CantidadMaxima = txtcantidadmaxima.Value
        xproducto.PuntoReorden = txtreorden.Value
        resultado = xrepoProducto.insert(xproducto)
        resultado = xrepositorioalmacen.insert(resultado)
        If resultado = 0 Then
            MessageBox.Show("El producto se creo exitosamente", "Creacion exitosa",
    MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Enabled = False
            guardado = True
        Else
            MessageBox.Show("Error al momento de crear el producto", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Len(Trim(txtcodigo.Text)) > 0 And Len(Trim(txtdescripcion.Text)) > 0 And Len(Trim(txtprecio.Text)) > 0 Then
            Guardar()
        Else
            MessageBox.Show("La descripcion y el codigo del producto son obligatorios, favor completelos", "Error",
  MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtdescripcion_LostFocus(sender As Object, e As EventArgs) Handles txtdescripcion.LostFocus
        txtdescripcion.Text = StrConv(txtdescripcion.Text, vbProperCase)
    End Sub
End Class
