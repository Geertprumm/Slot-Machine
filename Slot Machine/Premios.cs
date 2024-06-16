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
        public string Simbolo1 { get; set; }
        public string Simbolo2 { get; set; }
        public string Simbolo3 { get; set; }
        public int TipoPremio { get; set; }



        

        public Premios(int tipoPremios, string nombre, string simbolo1, string simbolo2, string simbolo3)
        {
            Nombre = nombre;
            Simbolo1 = simbolo1;
            Simbolo2 = simbolo2;
            Simbolo3 = simbolo3;
            TipoPremio = tipoPremios;
        }

        public string MostrarInformacion()
        {
            return $"Tipo de premio: {TipoPremio} --- \nNombre: {Nombre} --- \nSimbolo 1: {Simbolo1} --- \nSimbolo 2: {Simbolo2} --- \nSimbolo 3: {Simbolo3} ";
        }

        public bool ComprobarSimbolos(string s1, string s2, string s3)
        {

            if (s1 == Simbolo1 && s2 == Simbolo2 && s3 == Simbolo3) return true;
            else return false;

        }

    }
}
