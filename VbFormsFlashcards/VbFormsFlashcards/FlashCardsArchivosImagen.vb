Imports System.IO
Public Class FlashCardsArchivosImagen

    Public Sub New(origen As String, destino As String)

        File.Copy(origen, destino)

    End Sub


End Class
