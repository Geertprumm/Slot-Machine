using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class Premios
    {

        public string Nombre { get; set; }
        public int Simbolo1 { get; set; }
        public int Simbolo2 { get; set; }
        public int Simbolo3 { get; set; }
        public int TipoPremio { get; set; }



        public Premios(int tipoPremio, string nombre, int simbolo1, int simbolo2, int simbolo3)
        {
            Nombre = nombre;
            Simbolo1 = simbolo1;
            Simbolo2 = simbolo2;
            Simbolo3 = simbolo3;
            TipoPremio = tipoPremio;
        }


        public string MostrarInformacion()
        {
           return $"{Nombre} -- {Simbolo1} --- {Simbolo2} --- {Simbolo3} ";
        }

        public bool ComprobarSimbolos(int s1, int s2, int s3)
        {

            if (s1 == Simbolo1 && s2 == Simbolo2 && s3 == Simbolo3) return true;
            else return false;

        }

    }
}
