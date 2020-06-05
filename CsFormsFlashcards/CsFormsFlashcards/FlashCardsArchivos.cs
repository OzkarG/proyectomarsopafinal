using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsFormsFlashcards
{


    class FlashCardsArchivos
    {
  

        public void Guardartexto(string destino, string pregunta, string respuesta)
        {

            string destinofinal = destino + pregunta + ".txt";

            File.WriteAllText(destinofinal,respuesta);

      
        }

    }
}
