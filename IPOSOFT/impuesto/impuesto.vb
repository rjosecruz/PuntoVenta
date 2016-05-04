Public Class impuesto
    Private _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _impuesto As String
    Public Property Impuesto As String
        Get
            Return _impuesto
        End Get
        Set(value As String)
            _impuesto = value
        End Set
    End Property
    Private _porcentaje As Double
    Public Property Porcentaje As Double
        Get
            Return _porcentaje
        End Get
        Set(value As Double)
            _porcentaje = value
        End Set
    End Property
    Private _estado As Boolean
    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _impuesto
    End Function

    Public Sub New()

    End Sub

    Public Sub New(ByVal xid As Integer, ByVal ximpuesto As String)
        _id = xid
        _impuesto = ximpuesto
    End Sub
End Class
