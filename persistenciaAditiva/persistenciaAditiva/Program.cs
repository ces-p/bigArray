using System;

namespace persistenciaAditiva
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            int c = x;

            do
            {
                while (x / 10 >= 1)
                {
                    y += x % 10;
                    x /= 10;


                }
                Console.WriteLine(y);
            } while (y > 9);

        }
        
    }
}
