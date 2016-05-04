Public Class marca
    Private _id As Integer
    Private _marca As String
    Private _estado As Boolean

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
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

    Public Overrides Function ToString() As String
        Return _marca
    End Function


    Public Sub New()

    End Sub
    Public Sub New(ByVal xid As Integer, ByVal xmarca As String)
        _id = xid
        _marca = xmarca
    End Sub



End Class
