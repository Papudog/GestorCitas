Public Interface IConsulta
    Property Paciente As IPaciente
    Property Medico As IMedico
    Property FechaConsulta As DateTime
    Property HoraConsulta As DateTime
    Property Diagnostico As String
    Property Medicamentos As ICollection(Of String)
    Property MetodoPago As String
    Property NumeroTarjeta As String
    Property Subtotal As Decimal
    ReadOnly Property TotalIVA As Decimal
End Interface
