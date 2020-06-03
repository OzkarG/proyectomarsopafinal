using System;
using System.Collections.Generic;
using System.Text;

namespace CsConsolaJuegito
{
    interface ITerrestre
    {
        bool CantidadCocaina(int cantidad);
    }

   abstract class Vehiculos
    {
        private int Velocida;

        private int atrapa;

        public int AtrapadoPorba
        {
            get { return atrapa; }
            set { atrapa = value; }
        }

        public int Velocidad
        {
            get { return Velocida; }
            set { Velocida = value; }
        }


        public int Tardanza()
        {
            int x = 2500 / Velocida;
            return x;
        }

        public bool ganar() 
        {
            int ganarste = atrapa + ((Tardanza() * 1000) / 2500);

            if (ganarste <= 35) 
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public abstract string Tranportar();          

    }


    class Terrestre : Vehiculos, ITerrestre
    {
        private string nombre;
        public Terrestre(string nombre) 
        {
            this.nombre = nombre;
        }

        public override string Tranportar()
        {
            string texto = "Conduciras por las carreteras peligrosas con tu " + nombre;
            return texto;
        }

        public bool CantidadCocaina(int cantidad)
        {
            if (cantidad > 5)
            {
                return false;
            }
            else {
                return true;
            }
        }

    }

    class Maritimo : Vehiculos
    {
        private string nombre;
        public Maritimo(string nombre)
        {
            this.nombre = nombre;
        }
        public override string Tranportar()
        {
            string texto = "Navearas por el oceano con tu " + nombre;
            return texto;
        }
    }

    class Aereo : Vehiculos
    {
        private string nombre;
        public Aereo(string nombre) 
        {
            this.nombre = nombre;
        }
        public override string Tranportar()
        {
            string texto = "Volaras por los aires con tu " + nombre ;
            return texto;
        }
    }

}
