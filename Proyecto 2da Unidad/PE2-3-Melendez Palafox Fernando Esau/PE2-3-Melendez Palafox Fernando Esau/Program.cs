using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_3_Melendez_Palafox_Fernando_Esau
{
    class Orden
    {
        int aux;
        public int Ordenar(int[]arre,int cont,int limite)
        {
            if (cont < limite)
            {
                aux = arre[cont];
                arre[cont] = arre[limite];
                arre[limite] = aux;
                Ordenar(arre, cont + 1, limite - 1);
            }
            return aux;
        }
        public int Imprimir(int []arre1,int cont)
        {
            if (cont < arre1.Length)
            {
                Console.Write("[ {0} ]", arre1[cont]);
                Imprimir(arre1, cont + 1);
            }
            return cont;
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
                int[] arreglo = new int[cantidad]; Orden usuario = new Orden();
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Escriba el numero para la posicion {0}: ", i + 1);
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La sucesion al revez queda asi: ");
                usuario.Ordenar(arreglo, 0, cantidad - 1);
                usuario.Imprimir(arreglo, 0);
                Console.ReadKey();
            }catch(Exception e) { Console.Write(e.Message);Console.ReadKey(); }
        }
    }
}
