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

            File.AppendAllText("C:/Users/oscar/Desktop/Puntaje/puntaje.txt", x + " ");
           
        }

      

    }
}
