using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_1_Melendez_Palafox_Fernando_Esau
{
    class Operacion
    {
        public int Recursividad(int []arreglo,int cont,int min)
        {
            if (cont != arreglo.Length)
            {
                if (arreglo[cont] < min) { min = Recursividad(arreglo, cont + 1, arreglo[cont]); }
                else
                {
                    min = Recursividad(arreglo, cont + 1, min);
                }
            }
            return min;
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
                Operacion usuario1 = new Operacion();
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Escriba el numero para la posicion {0}: ", i + 1);
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El minimo ingresado es: {0}", usuario1.Recursividad(arreglo, 0, arreglo[0]));
                Console.ReadKey();
            }catch(Exception e) { Console.Write(e.Message);Console.ReadKey(); }
        }
    }
}
