Public Class producto
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Dim _codigo_barra As String
    Public Property CodigoBarras As String
        Get
            Return _codigo_barra
        End Get
        Set(value As String)
            _codigo_barra = value
        End Set
    End Property
    Dim _codigo_sap As String
    Public Property CodigoSap As String
        Get
            Return _codigo_sap
        End Get
        Set(value As String)
            _codigo_sap = value
        End Set
    End Property
    Dim _descripcion As String
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Dim _clasificacion_ID As Integer
    Public Property Clasificacion As Integer
        Get
            Return _clasificacion_ID
        End Get
        Set(value As Integer)
            _clasificacion_ID = value
        End Set
    End Property
    Dim _marca_ID As Integer
    Public Property Marca As Integer
        Get
            Return _marca_ID
        End Get
        Set(value As Integer)
            _marca_ID = value
        End Set
    End Property
    Dim _impuesto_ID As Integer
    Public Property Impuesto As Integer
        Get
            Return _impuesto_ID
        End Get
        Set(value As Integer)
            _impuesto_ID = value
        End Set
    End Property
    Dim _precio As Double
    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property
    Dim _unidades_por_caja As Double
    Public Property UxC As Double
        Get
            Return _unidades_por_caja
        End Get
        Set(value As Double)
            _unidades_por_caja = value
        End Set
    End Property
    Dim _costo_promedio As Double
    Public Property Costopromedio As Double
        Get
            Return _costo_promedio
        End Get
        Set(value As Double)
            _costo_promedio = value
        End Set
    End Property
    Dim _tiempo_reabastecimiento_semana As Double
    Public Property TiempoReabastecimiento As Double
        Get
            Return _tiempo_reabastecimiento_semana
        End Get
        Set(value As Double)
            _tiempo_reabastecimiento_semana = value
        End Set
    End Property
    Dim _semanas_en_mano As Double
    Public Property SemanasEnMano As Double
        Get
            Return _semanas_en_mano
        End Get
        Set(value As Double)
            _semanas_en_mano = value
        End Set
    End Property
    Dim _cantidad_maxima As Double
    Public Property CantidadMaxima As Double
        Get
            Return _cantidad_maxima
        End Get
        Set(value As Double)
            _cantidad_maxima = value
        End Set
    End Property
    Dim _cantidad_minima As Double
    Public Property CantidadMinima As Double
        Get
            Return _cantidad_minima
        End Get
        Set(value As Double)
            _cantidad_minima = value
        End Set
    End Property
    Dim _punto_reorden As Double
    Public Property PuntoReorden As Double
        Get
            Return _punto_reorden
        End Get
        Set(value As Double)
            _punto_reorden = value
        End Set
    End Property
    Dim _estado As Boolean
    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
    Dim _consumopromedio As Double
    Public Property ConsumoPromedio As Double
        Get
            Return _consumopromedio
        End Get
        Set(value As Double)
            _consumopromedio = value
        End Set
    End Property

    Public xClasificacion As clasificacion = New clasificacion
    Dim xrepoClasificacion As repoclasificacion = New repoclasificacion

    Public xImpuesto As impuesto = New impuesto
    Dim xrepoImpuesto As repoimpuesto = New repoimpuesto

    Public xMarca As marca = New marca
    Dim repoMarca As repomarca = New repomarca
    Dim _existencia As Double
    Public Property Existencia As Double
        Get
            Return _existencia
        End Get
        Set(value As Double)
            _existencia = value
        End Set
    End Property

    Public Sub getExtras()
        xClasificacion = xrepoClasificacion.findById(Clasificacion)
        xMarca = repoMarca.findById(Marca)
        xImpuesto = xrepoImpuesto.findById(Impuesto)
    End Sub

End Class
