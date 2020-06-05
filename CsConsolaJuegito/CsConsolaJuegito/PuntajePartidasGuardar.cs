using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CsConsolaJuegito
{
    class PuntajePartidasGuardar
    {
    

        public void Guardar(bool x)
         {
            try
            {
                File.AppendAllText("C:/Users/oscar/Desktop/Puntaje/puntaje.txt", x + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine("hubo un error: " + e);
            }
           
        }

      

    }
}
