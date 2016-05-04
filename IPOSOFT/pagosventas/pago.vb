Public Class pago
    Dim _ID As Integer
    Public Property Id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    Dim _fecha As DateTime
    Public Property Fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(value As DateTime)
            _fecha = value
        End Set
    End Property
    Dim _tipo_documento__ID As Integer
    Public Property TipoDocumento As Integer
        Get
            Return _tipo_documento__ID
        End Get
        Set(value As Integer)
            _tipo_documento__ID = value
        End Set
    End Property
    Dim numero_documento As String
    Public Property NumeroDocumento As Integer
        Get
            Return numero_documento
        End Get
        Set(value As Integer)
            numero_documento = value
        End Set
    End Property
    Dim saldo_anterior As Double
    Public Property SaldoAnterior As Double
        Get
            Return saldo_anterior
        End Get
        Set(value As Double)
            saldo_anterior = value
        End Set
    End Property
    Dim _pago As Double
    Public Property Pago As Double
        Get
            Return _pago
        End Get
        Set(value As Double)
            _pago = value
        End Set
    End Property
    Dim _saldo_nuevo As Double
    Public Property SaldoNuevo As Double
        Get
            Return _saldo_nuevo
        End Get
        Set(value As Double)
            _saldo_nuevo = value
        End Set
    End Property
    Dim factura__ID As Integer
    Public Property Factura As Integer
        Get
            Return factura__ID
        End Get
        Set(value As Integer)
            factura__ID = value
        End Set
    End Property
    Dim _id_vendedor As Integer
    Public Property Vendedor As Integer
        Get
            Return _id_vendedor
        End Get
        Set(value As Integer)
            _id_vendedor = value
        End Set
    End Property

End Class
