using System;
using System.Diagnostics;

namespace bigArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] big = new int[1073741823]; //numero binario mas grande antes del error de overflow

            var time = new Stopwatch();

            time.Start();
            int c = 0; //contador de iteraciones
            while (c != 1073741823)
            {
                TestA(big);
                
                c++;
            }
            time.Stop();

            Console.WriteLine($"Tiempo {time.ElapsedMilliseconds} ms"); //muestra el tiempo
        }

        static public int[] TestA(int[] array) //primer valor
        {
            array[0] = 0;
            return array;
        }

        static public int[] TestB(int[] array, int max) //ultimo valor
        { 
            array[max - 1] = 0;
            return array;
        }
    }
}
