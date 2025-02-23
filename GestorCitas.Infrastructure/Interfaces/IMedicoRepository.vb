Imports GestorCitas.Domain

Public Interface IMedicoRepository
    ReadOnly Property Medicos As ICollection(Of IMedico)
    ReadOnly Property Especialidades As ICollection(Of IEspecialidad)
End Interface