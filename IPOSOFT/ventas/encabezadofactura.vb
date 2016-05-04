Public Class encabezadofactura
    Dim _ID As Integer
    Public Property Id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    Dim _numero As Integer
    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property
    Dim _fecha_factura As Date
    Public Property Fecha As Date
        Get
            Return _fecha_factura
        End Get
        Set(value As Date)
            _fecha_factura = value
        End Set
    End Property
    Dim _tipo_fatura As String
    Public Property TipoFactura As String
        Get
            Return _tipo_fatura
        End Get
        Set(value As String)
            _tipo_fatura = value
        End Set
    End Property
    Dim _dias_credito As Integer
    Public Property DiasCredito As Integer
        Get
            Return _dias_credito
        End Get
        Set(value As Integer)
            _dias_credito = value
        End Set
    End Property
    Dim _cliente__ID As Integer
    Public Property IdCliente As Integer
        Get
            Return _cliente__ID
        End Get
        Set(value As Integer)
            _cliente__ID = value
        End Set
    End Property
    Dim _vendedor__ID As Integer
    Public Property Vendedor As Integer
        Get
            Return _vendedor__ID
        End Get
        Set(value As Integer)
            _vendedor__ID = value
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
    Dim _saldo As Double
    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property
    Dim __CAI As String
    Public Property CAI As String
        Get
            Return __CAI
        End Get
        Set(value As String)
            __CAI = value
        End Set
    End Property
    Dim _estado_pago__ID As Integer
    Public Property EstadoPago As Integer
        Get
            Return _estado_pago__ID
        End Get
        Set(value As Integer)
            _estado_pago__ID = value
        End Set
    End Property
    Dim _estado_factura__ID As Integer
    Public Property EstadoFactura As Integer
        Get
            Return _estado_factura__ID
        End Get
        Set(value As Integer)
            _estado_factura__ID = value
        End Set
    End Property
End Class
