Public Class detallefactura
    Dim _ID As Integer
    Public Property Id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    Dim _factura__ID As Integer
    Public Property Factura As Integer
        Get
            Return _factura__ID
        End Get
        Set(value As Integer)
            _factura__ID = value
        End Set
    End Property
    Dim _producto__ID As Integer
    Public Property IdProducto As Integer
        Get
            Return _producto__ID
        End Get
        Set(value As Integer)
            _producto__ID = value
        End Set
    End Property
    Dim _cantidad As Double
    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property
    Dim __precio As Double
    Public Property Precio As Double
        Get
            Return __precio
        End Get
        Set(value As Double)
            __precio = value
        End Set
    End Property
    Dim _subtotal_linea As Double
    Public Property Subtotal As Double
        Get
            Return _subtotal_linea
        End Get
        Set(value As Double)
            _subtotal_linea = value
        End Set
    End Property
    Dim _impuesto_linea As Double
    Public Property Impuesto As Double
        Get
            Return _impuesto_linea
        End Get
        Set(value As Double)
            _impuesto_linea = value
        End Set
    End Property
    Dim _total_linea As Double
    Public Property Total As Double
        Get
            Return _total_linea
        End Get
        Set(value As Double)
            _total_linea = value
        End Set
    End Property
    Dim _impuesto__ID As Integer
    Public Property IdImpuesto As Integer
        Get
            Return _impuesto__ID
        End Get
        Set(value As Integer)
            _impuesto__ID = value
        End Set
    End Property
End Class

