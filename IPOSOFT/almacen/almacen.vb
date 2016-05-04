Public Class almacen
    Dim _id As Integer
    Dim _almacen As String
    Dim _direccion As String
    Dim _estado As Boolean
    Dim _existencia As Double

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Almacen As String
        Get
            Return _almacen

        End Get
        Set(value As String)
            _almacen = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
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
    Public Sub New()

    End Sub
    Public Sub New(ByVal xid As Integer, ByVal xalmacen As String)
        _id = xid
        _almacen = xalmacen
    End Sub

    Public Overrides Function ToString() As String
        Return _almacen
    End Function

End Class
