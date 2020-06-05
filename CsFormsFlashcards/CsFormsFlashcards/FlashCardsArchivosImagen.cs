using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsFormsFlashcards
{
    class FlashCardsArchivosImagen
    {

        public FlashCardsArchivosImagen(string origen, string destino)
        {
            File.Copy(origen,destino);

        }

    }
}
