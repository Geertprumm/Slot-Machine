using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class PremiosAleatorios : Premios
    {

        public string Consejo1 { get; set; }
        public string Consejo2 { get; set; }
        public double Probabilidad { get; set; }

        public PremiosAleatorios(int tipoPremios, string nombre, int simbolo1, int simbolo2, int simbolo3, string consejo1, string consejo2, double probabilidad)
        : base(tipoPremios, nombre, simbolo1, simbolo2, simbolo3)
        {
            Consejo1 = consejo1;
            Consejo2 = consejo2;
            Probabilidad = probabilidad;
        }

    }
}
