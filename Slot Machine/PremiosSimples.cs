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


        public PremiosSimples(int tipopremio, string nombre, string simbolo1, string simbolo2, string simbolo3, string consejo)
        : base( tipopremio,nombre, simbolo1, simbolo2, simbolo3)
        {

            Consejo = consejo;

        }

       


    }
}
