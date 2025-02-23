﻿Imports GestorCitas.Domain

Public Interface IPacienteRepository
    ReadOnly Property Pacientes As ICollection(Of IPaciente)
    Function AgregarPaciente(paciente As IPaciente) As IPaciente
    Event OnPacientesChanged As Action(Of IPaciente)
End Interface
