Imports System.IO

Public Class PuntajePartidasGuardar


    Sub Guardar(x As Boolean)

        Dim z As String
        z = CStr(x) + " "


        File.AppendAllText("C:/Users/oscar/Desktop/Puntaje/puntaje.txt", z)




    End Sub









End Class
