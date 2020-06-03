Imports System.IO

Public Class PuntajePartidas


    Dim fileReader As StreamReader
    Public Sub New()

        Try

            fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:/Users/oscar/Desktop/Puntaje/puntaje.txt")
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            Console.WriteLine(stringReader)

        Catch ex As Exception

            Console.WriteLine("no se contro el archivo")

        End Try


    End Sub

    Sub Finalize()

        fileReader.Close()



    End Sub


End Class
