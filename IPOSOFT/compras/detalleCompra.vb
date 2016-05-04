Public Class detalleCompra
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim compra__ID As Integer
    Public Property IdCompra As Integer
        Get
            Return compra__ID
        End Get
        Set(value As Integer)
            compra__ID = value
        End Set
    End Property
    Dim producto__ID As Integer
    Public Property IdProducto As Integer
        Get
            Return producto__ID
        End Get
        Set(value As Integer)
            producto__ID = value
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
    Dim _precio As Double
    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property
    Dim _impuesto As Double
    Public Property Impuesto As Double
        Get
            Return _impuesto
        End Get
        Set(value As Double)
            _impuesto = value
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
    Dim _total_linea As Double
    Public Property TotalLinea As Double
        Get
            Return _total_linea
        End Get
        Set(value As Double)
            _total_linea = value
        End Set
    End Property

End Class
