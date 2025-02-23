Public Class Response
    Private _message As String
    Private _success As Boolean
    Private _data As Object

    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            _message = value
        End Set
    End Property

    Public Property Success As Boolean
        Get
            Return _success
        End Get
        Set(value As Boolean)
            _success = value
        End Set
    End Property

    Public Property Data As Object
        Get
            Return _data
        End Get
        Set(value As Object)
            _data = value
        End Set
    End Property
End Class