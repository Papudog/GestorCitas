Imports System.Drawing

Public Class Paciente
    Implements IPaciente

    Private Property _nombre As String
    Private Property _cedula As String
    Private Property _fechaNacimiento As DateTime
    Private Property _telefono As String
    Private Property _direccion As String
    Private Property _correo As String
    Private Property _foto As Image

    Public Property Nombre As String Implements IPaciente.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Cedula As String Implements IPaciente.Cedula
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements IPaciente.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(value As DateTime)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Telefono As String Implements IPaciente.Telefono
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Direccion As String Implements IPaciente.Direccion
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Correo As String Implements IPaciente.Correo
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Foto As Image Implements IPaciente.Foto
        Get
            Return _foto
        End Get
        Set(value As Image)
            _foto = value
        End Set
    End Property

    Public ReadOnly Property Edad As Integer Implements IPaciente.Edad
        Get
            Dim edadPaciente As Integer = DateTime.Today.Year - FechaNacimiento.Year
            If DateTime.Today.DayOfYear < FechaNacimiento.DayOfYear Then
                edadPaciente -= 1
            End If
            Return edadPaciente
        End Get
    End Property
End Class
