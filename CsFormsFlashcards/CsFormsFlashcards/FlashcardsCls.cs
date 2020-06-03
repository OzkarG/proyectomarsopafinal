using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsFormsFlashcards
{
    interface IImagen
    { 
    
        
    }

    abstract class FlashcardsCls
    {


    }

    class texto : FlashcardsCls
    { 
    
    
    }

    class Imagen : FlashcardsCls , IImagen
    { 
    
    }

}
