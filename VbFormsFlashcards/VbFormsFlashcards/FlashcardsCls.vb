Imports System.IO

Interface IImagen

    Function CargarImagen() As String

End Interface
Public MustInherit Class FlashcardsCls

    Public MustOverride Function obtenerdatos() As String()

    Public Function mostrarpregunta() As String

        Dim prg As String = obtenerdatos()(0)

        Return prg

    End Function

    Public Function mostrarrespeusta()

        Dim resp = obtenerdatos()(1)

        Return resp

    End Function

End Class

Public Class texto
    Inherits FlashcardsCls

    Dim Archivo As StreamReader

    Public Overrides Function obtenerdatos() As String()

        Dim filess() As String = Directory.GetFiles("C:/Users/oscar/Desktop/Puntaje/")

        Dim rdm As New Random
        Dim pp As Integer = rdm.Next(0, filess.Length)

        Dim spregut As String = filess(pp)

        Archivo = My.Computer.FileSystem.OpenTextFileReader(filess(pp))
        Dim respuesta = Archivo.ReadToEnd()

        Dim pregResp() As String = {spregut.Replace("C:/Users/oscar/Desktop/Puntaje/", "").Replace(".txt", ""), respuesta}

        Return pregResp

    End Function
End Class

Public Class Imagen
    Inherits FlashcardsCls
    Implements IImagen

    Public Overrides Function obtenerdatos() As String()

        Dim imajes() As String = Directory.GetFiles("C:/Users/oscar/Desktop/Imagen")

        Dim tn As New texto()

        Dim rut As String = "C:/Users/oscar/Desktop/Imagen" & "/" & tn.mostrarpregunta() & ".jpg"

        Dim pap As String = Convert.ToString(imajes.Contains(rut))

        Dim cont() As String = {pap, rut}

        Return cont

    End Function

    Public Function CargarImagen() As String Implements IImagen.CargarImagen

        Dim Soloruta As String = obtenerdatos()(1)

        Return Soloruta

    End Function
End Class



