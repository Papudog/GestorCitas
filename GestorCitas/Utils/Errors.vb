Module Errors
    Public Const IS_EMPTY As String = "isEmpty"
    Public Const INVALID_USER As String = "invalidUser"
    Public Const INVALID_CEDULA As String = "invalidCedula"
    Public Const INVALID_NACIMIENTO As String = "invalidNacimiento"
    Public Const INVALID_CORREO As String = "invalidCorreo"
    Public Const INVALID_TELEFONO As String = "invalidTelefono"
    Public Const INVALID_EDAD As String = "invalidEdad"

    Public Property ErrorDictionary As New Dictionary(Of String, String) From {
        {IS_EMPTY, "Este campo no puede estar vacío"},
        {INVALID_USER, "Usuario o contraseña incorrectos"},
        {INVALID_CEDULA, "Formato de cédula incorrecto"},
        {INVALID_NACIMIENTO, "La fecha de nacimiento no puede ser mayor o igual a la fecha actual"},
        {INVALID_CORREO, "Formato de correo incorrecto"},
        {INVALID_EDAD, "La edad no puede ser menor a 0"},
        {INVALID_TELEFONO, "El teléfono no tiene los caracteres necesarios"}
    }
End Module
