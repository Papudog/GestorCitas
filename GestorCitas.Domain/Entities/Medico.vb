Public Class Medico
    Implements IMedico

    Private Property _nombre As String
    Private Property _especialidad As IEspecialidad
    Private Property _consultorio As Integer

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

    Public Property Consultorio As Integer Implements IMedico.Consultorio
        Get
            Return _consultorio
        End Get
        Set(value As Integer)
            _consultorio = value
        End Set
    End Property
End Class
