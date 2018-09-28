using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_Melendez_PAlafox_Fernando_Esau
{
    class Operacion
    {
        public int y=1;
        public int Factfor() {
            for (int i = 1; i <= 6; i++) { y=y * i; }return y; }
        public int Factorial(int n) {
            if (n == 0) {  return 1; } else return n * Factorial(n - 1); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operacion Perro = new Operacion();
            Stopwatch Tiempo1 = new Stopwatch(); Tiempo1.Start();
            Console.WriteLine("El tiempo de un factorial en For: {0}\nY resultado: {1}", Tiempo1.Elapsed.ToString(), Perro.Factfor());
            Tiempo1.Stop();
            Stopwatch Tiempo2 = new Stopwatch(); Tiempo2.Start();
            Console.WriteLine("El tiempo de un factorial en Recursividad: {0}\nY resultado: {1}", Tiempo2.Elapsed.ToString(), Perro.Factorial(6));
            Tiempo2.Stop();
            Console.ReadKey();
        }
    }
}
