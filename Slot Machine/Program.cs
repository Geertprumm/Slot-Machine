using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            MaquinaSlots maquinaSlots = new MaquinaSlots();
            Admin admin = new Admin();
            admin.MaquinaSlots = maquinaSlots;
            Premios premios = new Premios();


            do
            {
                Console.Clear();
                Console.WriteLine("\t|||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("\t||                                               ||");
                Console.WriteLine("\t||      Bienvenido a la maquina de tragaperras   ||");
                Console.WriteLine("\t||                                               ||");
                Console.WriteLine("\t|||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("");
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||     Escoga la opción que quiera:               ||");
                Console.WriteLine("\t||     1. Jugar                                   ||");
                Console.WriteLine("\t||     2. Mostrar premios                         ||");
                Console.WriteLine("\t||     3. Cargar premios                          ||");         
                Console.WriteLine("\t||     5. Salir                                   ||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");


                switch (opcion)
                {
                    case 1:
                        maquinaSlots.Jugar(); break;
                    case 2:
                        Premios.MostrarInformacion(); break;

                }
            } while(opcion != 3  );

        }
    }
}
