Public Class productoalmacen

    Dim _idProducto As Integer
    Dim _idAlmancen As Integer
    Dim _existencia As Double
    Public Property IdPrducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property
    Public Property IdAlmacen As Integer
        Get
            Return _idAlmancen
        End Get
        Set(value As Integer)
            _idAlmancen = value
        End Set
    End Property
    Public Property Existencia As Double
        Get
            Return _existencia
        End Get
        Set(value As Double)
            _existencia = value
        End Set
    End Property

End Class
