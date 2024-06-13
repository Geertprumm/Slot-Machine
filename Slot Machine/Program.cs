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


            do
            {
                Console.Clear();
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||      Bienvenido a la maquina de tragaperras    ||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("");
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||     Escoga la opción que quiera:               ||");
                Console.WriteLine("\t||     1. Jugar                                   ||");
                Console.WriteLine("\t||     2. Mostrar premios                         ||");
                Console.WriteLine("\t||     3. Cargar premios                          ||");         
                Console.WriteLine("\t||     4. Salir                                   ||");
                Console.WriteLine("\t||                                                ||");
                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||||||||||||||");

                try
                {
                    Console.Write("\n\n\tOpcion: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            maquinaSlots.Jugar(); 
                            break;
                        case 2:
                            Console.Clear();
                            maquinaSlots.MostrarPremios(); 
                            break;
                        case 3:
                            Console.Clear();
                            admin.MenuAdmin(); 
                            break;
                        case 4:
                            
                            Console.WriteLine("Hasta la proxima");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("La opción nos es valida");
                            break;

                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }


            } while(opcion != 4  );

        }
    }
}
