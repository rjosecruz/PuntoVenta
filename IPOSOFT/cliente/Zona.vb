Public Class Zona
    Private _ID As Integer
    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal zona As String)
        _ID = id
        _zona = zona
    End Sub
    Public Property ID
        Get
            Return Me._ID
        End Get
        Set(value)
            Me._ID = value
        End Set
    End Property
    Private _zona As String

    Public Property zona
        Get
            Return Me._zona
        End Get
        Set(value)
            Me._zona = value
        End Set
    End Property

    Private _estado As Boolean
    Public Property estado As Boolean
        Get
            Return Me._estado
        End Get
        Set(value As Boolean)
            Me._estado = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _zona
    End Function

End Class
