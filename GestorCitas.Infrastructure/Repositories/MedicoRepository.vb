Imports GestorCitas.Domain

Public Class MedicoRepository
    Implements IMedicoRepository

    Private ReadOnly Property _especialidades As IEspecialidad() = {
        New Especialidad With {.Nombre = "Cardiología", .Costo = 2500},
        New Especialidad With {.Nombre = "Pediatría", .Costo = 1300},
        New Especialidad With {.Nombre = "Oftalmología", .Costo = 1800},
        New Especialidad With {.Nombre = "Dermatología", .Costo = 2000}
    }

    Private ReadOnly Property _consultorios As ICollection(Of Integer) = {1, 2, 3, 4}

    Private ReadOnly Property _medicos As ICollection(Of IMedico) = New List(Of IMedico) From {
        New Medico With {.Especialidad = Especialidades(0), .Nombre = "Dr. Juan Pérez", .Consultorio = _consultorios(0)},
        New Medico With {.Especialidad = Especialidades(1), .Nombre = "Dra. María Gómez", .Consultorio = _consultorios(1)},
        New Medico With {.Especialidad = Especialidades(2), .Nombre = "Dr. Carlos Rodríguez", .Consultorio = _consultorios(2)},
        New Medico With {.Especialidad = Especialidades(3), .Nombre = "Dra. Laura Martínez", .Consultorio = _consultorios(3)}
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

    Public ReadOnly Property Consultorios As ICollection(Of Integer) Implements IMedicoRepository.Consultorios
        Get
            Return _consultorios
        End Get
    End Property
End Class
