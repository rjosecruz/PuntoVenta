Public Class vendedor
    Dim _ID As Integer
    Dim _nombre As String
    Dim _direccion As String
    Dim _telefono As String
    Dim _estado As Boolean
    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal nombre As String)
        _ID = id
        _nombre = nombre
    End Sub
    Public Property Id
        Get
            Return Me._ID
        End Get
        Set(value)
            Me._ID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return Me._direccion
        End Get
        Set(value As String)
            Me._direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return Me._telefono
        End Get
        Set(value As String)
            Me._telefono = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return Me._estado
        End Get
        Set(value As Boolean)
            Me._estado = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return _nombre
    End Function
End Class
