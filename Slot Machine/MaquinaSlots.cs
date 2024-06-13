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

        private int[,]matrizjuego = new int[3,3];

        private List<Premios> Premios = new List<Premios>();

        private int[] simbolos = { 1,2,3,4,5,6,7,8,9,10};


        public MaquinaSlots() { }

        


        public void MostrarPremios()
        {
            foreach(Premios p in Premios) Console.WriteLine(p.MostrarInformacion());
        }

        public void Jugar()
        {
            string respuesta = null;
            Premios ComprobarGanador = null;
            do
            {
                for (int i = 0; i < matrizjuego.GetLength(0); i++)
                {
                    Random random = new Random();

                    int numeroaleatorio = random.Next(simbolos[i]);

                    for (int j = 0; j < matrizjuego.GetLength(1); j++)
                    {
                        matrizjuego[i, j] = numeroaleatorio;
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
                if(ComprobarGanador != null)
                {
                    Console.WriteLine(ComprobarGanador.Nombre);
                }
                else
                {
                    Console.WriteLine("No ha habido suerte, ¿Quieres jugar otra vez? (S/N)");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta != "N");

           
        }


        public void ImprimirMatriz()
        {
            for (int i = 0; i < matrizjuego.GetLength(0); i++)
            {

                for (int j = 0; j < matrizjuego.GetLength(1); j++)
                {
                    Console.Write($"{matrizjuego[i,j]}");
                }
                Console.WriteLine();
            }
        }


        public void CargarPremios(string archivo)
        {
            using (StreamReader sr = new StreamReader(archivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');

                    if (datos[0] == "1")
                    {
                        PremiosSimples p = new PremiosSimples(int.Parse(datos[0]), datos[1], int.Parse(datos[2]), int.Parse(datos[3]), int.Parse(datos[4]), datos[5]);
                        Premios.Add(p);
                    }
                    else
                    {
                        PremiosAleatorios p = new PremiosAleatorios(int.Parse(datos[0]), datos[1], int.Parse(datos[3]), int.Parse(datos[4]), int.Parse(datos[5]), datos[6], datos[7], double.Parse(datos[8]));
                        Premios.Add(p);
                    }
                }
            }
        }

    }
}
