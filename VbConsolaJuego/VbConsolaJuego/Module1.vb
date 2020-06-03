Module Module1

    Sub Main()

        Dim prd As New PuntajePartidasGuardar()

        Dim Noticias() As String =
            {
          "Notifico la E.U.A que reforzo la guardia marina de miami.",
                "Detectaron una avioneta volando prosuntamente volando por florida, con posible droga.",
                "El presidente de los Estados unidos quiere reelegirse como presiente.",
                "La ciudad de mexico sufrio otro terremotro hace menos de 24 horas.",
                "Abra un gran evento en miami el proximo mes, asistiras personas de otros estados."
            }

        Console.WriteLine("Antes de empezar la partida deseas ver tu historial de victorias?  s/n")
        Dim resp As String
        resp = Console.ReadLine()

        If resp = "s" Then
            Dim panta As PuntajePartidas()

        Else


        End If

        Console.ReadKey()
        Console.WriteLine("Eres Pablo escobar y estas a punto de transportar 15 kilos de cocaina a Florida, pero")
        Console.ReadKey()
        Console.WriteLine("dudas del metodo mas eficaz para transportarla, asi que escoje bien")
        Console.ReadKey()
        Console.WriteLine("En estos momentos estas en la peninsula de Yucatan, tienes 48 horas para entregar el pedido ")
        Console.ReadKey()
        Console.WriteLine("Puedes ver las noticias para darte una idea de que veiculo es mas prudente usar")
        Console.ReadKey()

        For Each x In Noticias
            Console.WriteLine("Times: " & x)
        Next

        Console.WriteLine("Opciones: a) Escojer Vehiculo b) Cerrar")
        Dim respuesta As String
        respuesta = Console.ReadLine()

        If respuesta = "a" Then

            Console.WriteLine("a) terrestre  b) maritimo  c) aereo")
            Dim respuesta2 As String
            respuesta2 = Console.ReadLine()

            Select Case respuesta2
                Case "a"
                    Console.WriteLine("Escojiste terrestre")
                    Console.WriteLine("Cual sera el nombre de tu vehiculo terrestre")
                    Dim nombrevehi As String
                    nombrevehi = Console.ReadLine()

                    Dim terres As New Terrestre(nombrevehi)
                    Console.WriteLine("Los vehiculos terrestres tiene un limite para la cantidad de droga: cuanta llevaras?")

                    Try
                        Dim canti As Integer
                        canti = CInt(Console.ReadLine())

                        Console.WriteLine("No cometas errores >:(")

                        If terres.CantidadCocaina(canti) = False Then
                            Console.WriteLine("No conozes las reglas del nacrotrafico, NO ERES UN NARCOTRAFICANTE, ATRAPENLO")
                            Console.ReadKey()

                            Environment.Exit(0)
                        End If
                        Console.WriteLine("Muy bien, solo falta que tan rapido conduciras")
                        terres.Velocidad = CInt(Console.ReadLine())
                        terres.AtrapadoPorba = 45
                        Console.WriteLine(terres.Tranportar())

                    Catch ex As Exception
                        Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :")
                        Console.WriteLine(ex)
                        Console.ReadKey()

                    End Try

                    If terres.ganar() = False Then
                        Console.WriteLine("ni modo, te mataron, chale, uno que se quiere ganar la vida.")
                        prd.Guardar(terres.ganar())
                    Else
                        prd.Guardar(terres.ganar())
                        Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)")

                    End If

                Case "b"
                    Console.WriteLine("Esojiste maritimo")
                    Console.WriteLine("Cual sera le nombre de tu vehiculo maritimo")
                    Dim nombremari As String
                    nombremari = Console.ReadLine()

                    Dim mari As New Maritimo(nombremari)

                    Try
                        Console.WriteLine("Muy bien, que tan rapido navegaras: ")
                        mari.Velocidad = CInt(Console.ReadLine())

                        mari.AtrapadoPorba = 20
                        Console.WriteLine(mari.Tranportar())

                    Catch ex As Exception
                        Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :")
                        Console.WriteLine(ex)

                    End Try
                    If mari.ganar() = False Then
                        Console.WriteLine("Ni modo, te mataron, chale")
                        prd.Guardar(mari.ganar())

                    Else
                        prd.Guardar(mari.ganar())
                        Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)")

                    End If


                Case "c"
                    Console.WriteLine("Aereo")
                    Console.WriteLine("Cual sera el nombre de tu vehiculo aereo")
                    Dim nombreaereo As String
                    nombreaereo = Console.ReadLine()

                    Dim Aere As New Aereo(nombreaereo)

                    Try
                        Console.WriteLine("Muy bien, que tan rapido volaras: ")
                        Aere.Velocidad = CInt(Console.ReadLine())

                        Aere.AtrapadoPorba = 20
                        Console.WriteLine(Aere.Tranportar())

                    Catch ex As Exception
                        Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :")
                        Console.WriteLine(ex)

                    End Try
                    If Aere.ganar() = False Then
                        Console.WriteLine("Ni modo, te mataron, chale")
                        prd.Guardar(Aere.ganar())

                    Else
                        prd.Guardar(Aere.ganar())
                        Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)")

                    End If

            End Select




        Else
            Environment.Exit(0)
        End If


        Console.ReadKey()

    End Sub

End Module
