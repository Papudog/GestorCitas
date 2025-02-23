Imports System.Drawing

Public Interface IPaciente
    Property Nombre As String
    Property Cedula As String
    Property FechaNacimiento As DateTime
    Property Telefono As String
    Property Direccion As String
    Property Correo As String
    Property Foto As Image
    ReadOnly Property Edad As Integer
End Interface
