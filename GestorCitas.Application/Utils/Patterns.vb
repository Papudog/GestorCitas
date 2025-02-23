Imports System.Text.RegularExpressions

Module Patterns
    Public ReadOnly Property REGEX_CEDULA As New Regex("^\d{3}-\d{6}-\d{4}[A-Z]$")
    Public ReadOnly Property REGEX_CORREO As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
End Module
