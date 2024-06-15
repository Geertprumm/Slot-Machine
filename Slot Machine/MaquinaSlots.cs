using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class MaquinaSlots
    {

        private int[ , ] matrizjuego = new int[3 , 3];

        private List<Premios> Premios = new List<Premios>();

        private int[] simbolos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static Random Random = new Random();


        public MaquinaSlots() { }




        public void MostrarPremios()
        {
            foreach (Premios p in Premios) Console.WriteLine(p.MostrarInformacion());
        }

        public void Jugar()
        {
            string respuesta = null;
            Premios ComprobarGanador = null;
            do
            {
                for (int i = 0; i < matrizjuego.GetLength(0); i++)
                {


                    int numeroaleatorio = Random.Next(simbolos[i]);

                    for (int j = 0; j < matrizjuego.GetLength(1); j++)
                    {
                        int numeroAleatorio = Random.Next(0, simbolos.Length);
                        matrizjuego[i, j] = simbolos[numeroAleatorio];
                    }
                }
                ImprimirMatriz();
                foreach (Premios p in Premios)
                {
                    if (p.ComprobarSimbolos(matrizjuego[1, 0], matrizjuego[1, 1], matrizjuego[1, 2]))
                    {
                        ComprobarGanador = p;
                    }

                }
                if (ComprobarGanador != null)
                {
                    Console.WriteLine(ComprobarGanador.Nombre);
                }
                else
                {
                    Console.WriteLine("No ha habido suerte, ¿Quieres jugar otra vez? (s/n)");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta != "n");


        }


        public void ImprimirMatriz()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrizjuego.GetLength(0); i++)
            {

                for (int j = 0; j < matrizjuego.GetLength(1); j++)
                {
                    sb.Append(matrizjuego[i, j]);
                    if (j < matrizjuego.GetLength(1) - 1)
                    {
                        sb.Append(" | ");
                    }
                    
                }
                sb.AppendLine();
                
            }
            Console.WriteLine(sb.ToString());
        }


        public void CargarPremios(string archivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(';');
                        if (datos.Length < 5 || (datos[0] == "2" && datos.Length < 8))
                        {
                            Console.WriteLine("Datos incompletos o corruptos en el archivo.");
                            continue;
                        }

                        try
                        {
                            if (datos[0] == "1")
                            {
                                PremiosSimples p = new PremiosSimples(int.Parse(datos[0]), datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5]);
                                Premios.Add(p);
                            }
                            else
                            {
                                PremiosAleatorios p = new PremiosAleatorios(int.Parse(datos[0]), datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5], datos[6], double.Parse(datos[7]));
                                Premios.Add(p);
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Error de formato en los datos: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error desconocido al cargar el premio: {ex.Message}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo especificado no existe.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de IO al acceder al archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error desconocido al cargar premios: {ex.Message}");
            }
        }
    }
}
