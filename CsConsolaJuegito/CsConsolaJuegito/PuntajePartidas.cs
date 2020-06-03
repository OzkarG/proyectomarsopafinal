using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CsConsolaJuegito
{
    class PuntajePartidas
    {

        StreamReader archivo = null;
        public PuntajePartidas()
        {
             
                try
                {
                    archivo = new StreamReader("C:/Users/oscar/Desktop/Puntaje/puntaje.txt");
                    string texto = archivo.ReadToEnd();

                    string[] valores = texto.Split(' ');
                    foreach (string x in valores)
                    {
                        Console.WriteLine(x);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("El archivo no fue encontrado");
                }
            
        }
        ~PuntajePartidas()
        {
            archivo.Close();
        }



    }
}
