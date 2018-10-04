using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_2_Melendez_Palafox_Fernando_Esau
{
    class Maximo
    {
        public int Recursividad(int[] arreglo, int cont, int max)
        {
            if (cont != arreglo.Length)
            {
                if (arreglo[cont] > max) { max = Recursividad(arreglo, cont + 1, arreglo[cont]); }
                else
                {
                    max = Recursividad(arreglo, cont + 1, max);
                }
            }
            return max;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cuantos numeros desea ingresar?: ");
                int cantidad = int.Parse(Console.ReadLine());
                int[] arreglo = new int[cantidad];
                Maximo usuario1 = new Maximo();
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Escriba el numero para la posicion {0}: ", i + 1);
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El maximo ingresado es: {0}", usuario1.Recursividad(arreglo, 0, arreglo[0]));
                Console.ReadKey();
            }
            catch (Exception e) { Console.Write(e.Message); Console.ReadKey(); }
        }
    }
}
