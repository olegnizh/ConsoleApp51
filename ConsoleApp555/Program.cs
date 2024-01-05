using System;

namespace ConsoleApp555
{
    class Program
    {
        static void Main(string[] args)
        {            

            int x = Factorial(20);

            Console.WriteLine("Получилось {0}", x);
            Console.ReadKey();

        }

        static int Factorial(int x)
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
