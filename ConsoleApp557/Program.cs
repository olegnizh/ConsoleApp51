using System;

namespace ConsoleApp557
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = Factorial(20);

            Console.WriteLine("Получилось {0}", x);
            Console.ReadKey();
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

    }
}
