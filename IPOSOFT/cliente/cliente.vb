Public Class cliente
    Dim _id As Integer
    Public xzona As Zona = New Zona
    Public xvendedor As vendedor = New vendedor
    Dim xrepozona As zonaRepositorio = New zonaRepositorio
    Dim xrepovendedor As repoVendedor = New repoVendedor
    Public Property Id As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property
    Dim _rtn As String
    Public Property Rtn As String
        Get
            Return Me._rtn
        End Get
        Set(value As String)
            Me._rtn = value
        End Set
    End Property
    Dim _nombre As String
    Public Property Nombre As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property
    Dim _direccion As String
    Public Property Direccion As String
        Get
            Return Me._direccion
        End Get
        Set(value As String)
            Me._direccion = value
        End Set
    End Property
    Dim _idzona As Integer
    Public Property Idzona As Integer
        Get
            Return Me._idzona
        End Get
        Set(value As Integer)
            Me._idzona = value

        End Set
    End Property
    Dim _idvendedor As Integer
    Public Property Idvendedor As Integer
        Get
            Return Me._idvendedor
        End Get
        Set(value As Integer)
            Me._idvendedor = value

        End Set
    End Property
    Dim _saldo As Double
    Public Property Saldo As Double
        Get
            Return Me._saldo
        End Get
        Set(value As Double)
            Me._saldo = value
        End Set
    End Property
    Dim _limitecredito As Double
    Public Property Limitecredito As Double
        Get
            Return Me._limitecredito
        End Get
        Set(value As Double)
            Me._limitecredito = value
        End Set
    End Property
    Dim _estado As Boolean
    Public Property Estado As Boolean
        Get
            Return Me._estado
        End Get
        Set(value As Boolean)
            Me._estado = value
        End Set
    End Property
    Dim _diascredito As Double
    Public Property Diascredito As Integer
        Get
            Return _diascredito
        End Get
        Set(value As Integer)
            _diascredito = value
        End Set
    End Property
    Dim _mail As String
    Public Property Mail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
        End Set
    End Property
    Dim _telefono As String
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Dim _movil As String
    Public Property Movil As String
        Get
            Return _movil
        End Get
        Set(value As String)
            _movil = value
        End Set
    End Property
    Dim _contacto As String
    Public Property Contacto As String
        Get
            Return _contacto
        End Get
        Set(value As String)
            _contacto = value
        End Set
    End Property
    Dim _latitud As Double
    Public Property Latitud As Double
        Get
            Return _latitud
        End Get
        Set(value As Double)
            _latitud = value
        End Set
    End Property
    Dim _longitud As Double
    Public Property Longitud As Double
        Get
            Return _longitud
        End Get
        Set(value As Double)
            _longitud = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene los datos de los vendedores y las zonas
    ''' </summary>
    Public Sub getExtras()
        xvendedor = xrepovendedor.findById(Me.Idvendedor)
        xzona = xrepozona.findById(Me.Idzona)
    End Sub
End Class
