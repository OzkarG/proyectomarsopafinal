using System;

namespace CsConsolaJuegito
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntajePartidasGuardar prd = new PuntajePartidasGuardar();


            string[] Noticias = new string[5] 
            {
                "Notifico la E.U.A que reforzo la guardia marina de miami.",
                "Detectaron una avioneta volando prosuntamente volando por florida, con posible droga.",
                "El presidente de los Estados unidos quiere reelegirse como presiente.",
                "La ciudad de mexico sufrio otro terremotro hace menos de 24 horas.",
                "Abra un gran evento en miami el proximo mes, asistiras personas de otros estados."
            };


            Console.WriteLine("Antes de empezar la partida deseas ver tu historial de victorias?  s/n");
            if (Console.ReadLine() == "s")
            {
                PuntajePartidas panta = new PuntajePartidas();

            }
            else
            {
     
            }
            Console.ReadKey();
            Console.WriteLine("Eres Pablo escobar y estas a punto de transportar 15 kilos de cocaina a Florida, pero");
            Console.ReadKey();
            Console.WriteLine("dudas del metodo mas eficaz para transportarla, asi que escoje bien");
            Console.ReadKey();
            Console.WriteLine("En estos momentos estas en la peninsula de Yucatan, tienes 48 horas para entregar el pedido ");
            Console.ReadKey();
            Console.WriteLine("Puedes ver las noticias para darte una idea de que veiculo es mas prudente usar");
            Console.ReadKey();

            foreach (string x in Noticias)
            {
                Console.WriteLine("Times: " + x);
            }

            Console.WriteLine("Opciones: a) Escojer Vehiculo b) Cerrar");
            string respuesta = Console.ReadLine();

            if (respuesta == "a")
            {
                Console.WriteLine("a) terrestre  b) maritimo  c) aereo");
                string respuesta2 = Console.ReadLine();

                switch (respuesta2)
                {
                    case "a": Console.WriteLine("escojiste terrestre");

                        Console.WriteLine("Cual sera el nombre de tu vehiculo terrestre :");
                        string nombrevehi = Console.ReadLine();

                        Terrestre terres = new Terrestre(nombrevehi);
                        Console.WriteLine("Los vehiculos terrestres tienen un limite para la cantidad de droga: Cuanta llevaras?");

                        try
                        {
                            int canti = Convert.ToInt16(Console.ReadLine());


                            Console.WriteLine("no cometas errores >:(");


                            if (terres.CantidadCocaina(canti) == false)
                            {
                                Console.WriteLine("No conozes las reglas del nacrotrafico, NO ERES UN NARCOTRAFICANTE, ATRAPENLO");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Muy bien, solo falta que tan rapido conduciras");
                            terres.Velocidad = Convert.ToInt32(Console.ReadLine());

                            terres.AtrapadoPorba = 45;
                            Console.WriteLine(terres.Tranportar());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :" + e);
                        }

                        if (terres.ganar() == false)
                        {
                            Console.WriteLine("ni modo, te mataron, chale, uno que se quiere ganar la vida.");
                            prd.Guardar(terres.ganar());
                        }
                        else {
                            prd.Guardar(terres.ganar());
                            Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)");
                        }
                

                        break;

                    case "b": Console.WriteLine("Escojistre maritimo");

                        Console.WriteLine("Cual sera el nombre de tu vehiculo maritimo :");
                        string nombremari = Console.ReadLine();

                        Maritimo mari = new Maritimo(nombremari);                       

                        try
                        {                           
                            Console.WriteLine("Muy bien, Que tan rapido navegaras: ");
                            mari.Velocidad = Convert.ToInt32(Console.ReadLine());

                            mari.AtrapadoPorba = 20;
                            Console.WriteLine(mari.Tranportar());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :" + e);
                        }

                        if (mari.ganar() == false)
                        {
                            Console.WriteLine("Ni modo, te mataron, chale");
                            prd.Guardar(mari.ganar());
                        }
                        else
                        {
                            prd.Guardar(mari.ganar());
                            Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)");
                        }
                      

                        break;

                    case "c": Console.WriteLine("Escojistre Aereo");

                        Console.WriteLine("Cual sera el nombre de tu vehiculo aereo :");
                        string nombreaereo = Console.ReadLine();

                        Aereo Aere = new Aereo(nombreaereo);

                        try
                        {
                            Console.WriteLine("Muy bien, Que tan rapido volaras: ");
                            Aere.Velocidad = Convert.ToInt32(Console.ReadLine());

                            Aere.AtrapadoPorba = 50;
                            Console.WriteLine(Aere.Tranportar());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Cometiste algun error >:(  hazlo de nuevo :" + e);
                        }

                        if (Aere.ganar() == false)
                        {
                            prd.Guardar(Aere.ganar());
                            Console.WriteLine("ni modo, te mataron, chale, en tu proxima vida aver si puedes");
                        }
                        else
                        {
                            prd.Guardar(Aere.ganar());
                            Console.WriteLine("Felicidades, lograste tranpostar la droga sin que te atrapan, solo falta que regreses a salvo :)");
                        }
                        break;
                
                }


            }
            else if (respuesta == "b")
            {
                Environment.Exit(0);
            }

            Console.ReadKey();

     


            

        }
    }
}
