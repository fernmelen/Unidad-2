using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_Melendez_Palafox_Fernando_Esau
{
    class Fibonacci
    {
        public int limite;public int aux1 = 1;public long aux2 = 1;public long res;
        public Fibonacci(int lim) { limite = lim; }
        public void Iterativo()
        {
            Console.Write("[ 0 ]"); Console.Write("[ 1 ]");
            if (limite>=3)
            {
                int res = 1;
                for(int i = 0; i < limite - 2; i++)
                {
                    Console.Write("[ {0} ]", res);
                    res = aux1 + res;
                    aux1 = res - aux1;
                }
                Console.WriteLine();
            }
        }
        public long Recursivo(int lim)
        {
            if (lim > 0)
            {
                Console.Write("( {0} )", res);
                res = res + aux2;
                aux2 = res - aux2;
                return Recursivo(lim - 1);
            }
            else
                return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un indice deseado de Fubonacci: ");
            int indice = int.Parse(Console.ReadLine());
            Fibonacci Usuario = new Fibonacci(indice);
            Stopwatch TiempoFor = new Stopwatch();TiempoFor.Start();
            Usuario.Iterativo();
            Console.WriteLine("Tiempo de ejecucion iterativo: {0}", TiempoFor.Elapsed.ToString());
            Stopwatch TiempoRecurs = new Stopwatch();TiempoRecurs.Start();
            Usuario.Recursivo(indice);
            Console.WriteLine("\nTiempo de ejecucion recursivo: {0}", TiempoRecurs.Elapsed.ToString());
            Console.ReadKey();
        }
    }
}
