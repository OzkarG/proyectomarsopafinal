Imports System.IO
Public Class FlashCardsArchivos


    Public Sub GuardarTexto(destino As String, pregunta As String, respuesta As String)

        Dim destinofinal As String = destino & pregunta & ".txt"

        File.WriteAllText(destinofinal, respuesta)


    End Sub



End Class
