using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class PremiosSimples :Premios
    {

        public string Consejo {  get; set; }


        public PremiosSimples(int tipopremio, string nombre, int simbolo1, int simbolo2, int simbolo3, string consejo)
        : base( tipopremio,nombre, simbolo1, simbolo2, simbolo3)
        {

            Consejo = consejo;

        }

    }
}
