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

        private int Contraseña {  get; set; }
        public string Nombre { get; set; }  

        public MaquinaSlots  MaquinaSlots { get; set; }


        public Admin() { }

        public Admin(int contraseña,string nombre)
        {
            Contraseña = contraseña;
            Nombre = nombre;
        }



        public void MenuAdmin()
        {
            Console.WriteLine("Introduce el nombre del archivo para recargar los productos: ");
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
    }
}
