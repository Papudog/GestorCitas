Imports GestorCitas.Domain

Public Class MedicoRepository
    Implements IMedicoRepository

    Private ReadOnly Property _medicos As ICollection(Of IMedico) = New List(Of IMedico) From {
        New Medico With {.Especialidad = Especialidades(0), .Nombre = "Dr. Juan Pérez"},
        New Medico With {.Especialidad = Especialidades(1), .Nombre = "Dra. María Gómez"},
        New Medico With {.Especialidad = Especialidades(2), .Nombre = "Dr. Carlos Rodríguez"},
        New Medico With {.Especialidad = Especialidades(3), .Nombre = "Dra. Laura Martínez"}
    }

    Private ReadOnly Property _especialidades As IEspecialidad() = {
        New Especialidad With {.Nombre = "Cardiología"},
        New Especialidad With {.Nombre = "Pediatría"},
        New Especialidad With {.Nombre = "Oftalmología"},
        New Especialidad With {.Nombre = "Dermatología"}
    }

    Public ReadOnly Property Medicos As ICollection(Of IMedico) Implements IMedicoRepository.Medicos
        Get
            Return _medicos
        End Get
    End Property

    Public ReadOnly Property Especialidades As ICollection(Of IEspecialidad) Implements IMedicoRepository.Especialidades
        Get
            Return _especialidades
        End Get
    End Property
End Class
