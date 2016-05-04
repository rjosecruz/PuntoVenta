Public Class clasificacion
    Private _id As Integer
    Private _clasificacion As String
    Private _estado As Boolean
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Clasificacion As String
        Get
            Return _clasificacion
        End Get
        Set(value As String)
            _clasificacion = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal xid As Integer, ByVal xclasificacion As String)
        _id = xid
        _clasificacion = xclasificacion
    End Sub

    Public Overrides Function ToString() As String
        Return _clasificacion
    End Function
End Class
