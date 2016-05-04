Public Class encabezadoCompra
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim _documento As String
    Public Property Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property
    Dim _fecha As Date
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Dim proveedor__ID As Integer
    Public Property Proveedor As Integer
        Get
            Return proveedor__ID
        End Get
        Set(value As Integer)
            proveedor__ID = value
        End Set
    End Property
    Dim estado_compra__ID As Integer
    Public Property Estado As Integer
        Get
            Return estado_compra__ID
        End Get
        Set(value As Integer)
            estado_compra__ID = value
        End Set
    End Property
    Dim fecha_requerida As Date
    Public Property FechaRequerida As Date
        Get
            Return fecha_requerida
        End Get
        Set(value As Date)
            fecha_requerida = value
        End Set
    End Property
    Dim _subtotal As Double
    Public Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
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
    Dim _total As Double
    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
End Class
