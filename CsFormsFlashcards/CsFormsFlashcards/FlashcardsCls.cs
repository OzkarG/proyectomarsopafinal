using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsFormsFlashcards
{
    interface IImagen
    {
        string CargarImagen();
    }

    abstract class FlashcardsCls
    {
        public abstract string[] obtenerdatos();

        public string mostrarpregunta()
        {
            string prg = obtenerdatos()[0];

            return prg;
        }

        public string mostrarrespeusta()
        {
            string resp = obtenerdatos()[1];
            return resp;
        }


    }

    class texto : FlashcardsCls
    {
        StreamReader Archivo;
        public override string[] obtenerdatos()
        {
            string[] filess = Directory.GetFiles("C:/Users/oscar/Desktop/Puntaje/");
            Random rdm = new Random();
            int pp = rdm.Next(0, filess.Length);

            string spregut = filess[pp];

             Archivo = new StreamReader(filess[pp]);
            string respuesta = Archivo.ReadToEnd();

            string[] pregResp = new string[2] { spregut.Replace("C:/Users/oscar/Desktop/Puntaje/", "").Replace(".txt", ""), respuesta };

            return pregResp;
        }

        ~texto()
        {
            Archivo.Close();
        }
    }
   

    class Imagen : FlashcardsCls, IImagen
    {
        public string CargarImagen()
        {
            string Soloruta = obtenerdatos()[1];

            return Soloruta;
        }

        public override string[] obtenerdatos()
        {

            string[] imajes = Directory.GetFiles("C:/Users/oscar/Desktop/Imagen");

            texto tn = new texto();
            string rut = "C:/Users/oscar/Desktop/Imagen" + "/" + tn.mostrarpregunta() + ".jpg";
            
            string pap =  Convert.ToString(imajes.Contains(rut));

            string[] cont = new string[2] { pap, rut };
                    
            
            return cont;
        }

    }
}
