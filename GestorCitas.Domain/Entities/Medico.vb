Public Class Medico
    Implements IMedico

    Private Property _nombre As String
    Private Property _especialidad As IEspecialidad

    Public Property Nombre As String Implements IMedico.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Especialidad As IEspecialidad Implements IMedico.Especialidad
        Get
            Return _especialidad
        End Get
        Set(value As IEspecialidad)
            _especialidad = value
        End Set
    End Property
End Class
