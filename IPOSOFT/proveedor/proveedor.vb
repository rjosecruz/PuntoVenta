Public Class proveedor
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Dim _codigo As String
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Dim _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Dim _representante As String
    Public Property Representante As String
        Get
            Return _representante
        End Get
        Set(value As String)
            _representante = value
        End Set
    End Property
    Dim _direccion As String
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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
    Dim _email As String
    Public Property Mail As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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
    Dim _pais As String
    Public Property Pais As String
        Get
            Return _pais
        End Get
        Set(value As String)
            _pais = value
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
End Class
