Imports GestorCitas.Domain

Public Interface IConsultaRepository
    ReadOnly Property Consultas As ICollection(Of IConsulta)
    Function AgregarConsulta(consulta As IConsulta) As IConsulta
    Event OnConsultasChanged As Action(Of IConsulta)
End Interface
