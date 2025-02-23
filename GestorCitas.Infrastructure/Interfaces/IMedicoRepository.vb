Imports GestorCitas.Domain

Public Interface IMedicoRepository
    ReadOnly Property Medicos As ICollection(Of IMedico)
    ReadOnly Property Especialidades As ICollection(Of IEspecialidad)
    ReadOnly Property Consultorios As ICollection(Of Integer)
End Interface