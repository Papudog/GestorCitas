Public Class Especialidad
    Implements IEspecialidad

    Private Property _nombre As String

    Public Property Nombre As String Implements IEspecialidad.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
