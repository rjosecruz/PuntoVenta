Public Class tipodocumento
    Dim _id As Integer
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public _documento As String
    Public Property Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property
    Public Sub New(ByVal xid As Integer, ByVal xdocumento As String)
        _id = xid
        _documento = xdocumento
    End Sub
    Public Overrides Function ToString() As String
        Return _documento
    End Function
End Class
