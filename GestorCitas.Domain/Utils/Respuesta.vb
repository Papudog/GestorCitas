Public Class Respuesta
    Public Shared Function Crear(message As String, success As Boolean, data As Object) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From {
            {ResponseConstants.MESSAGE, message},
            {ResponseConstants.SUCCESS, success},
            {ResponseConstants.DATA, data}
        }
    End Function
End Class