using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class Admin
    {
        public const string adminClave = "admin123";
          

        public MaquinaSlots  MaquinaSlots { get; set; }



        public void MenuAdmin()
        {
            Console.WriteLine("Introduce el nombre del archivo para recargar los premios: ");
            string archivo = Console.ReadLine();
            if(string.IsNullOrEmpty(archivo))
            {
                Console.WriteLine("No dejes campos vacios");
            }
            else
            {
                if(File.Exists(archivo))
                {
                    MaquinaSlots.CargarPremios(archivo);
                }
                else
                {
                    Console.WriteLine("El archivo no existe");
                }
            }
        }

        public bool AutenticarAdmin()
        {
            Console.Write("Introduce la clave de administrador: ");
            string clave = Console.ReadLine();
            if (clave == adminClave)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Clave incorrecta.");
                return false;
            }
        }
    }
}
