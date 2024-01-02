using System;

namespace ConsoleApp5311
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 5;
            int num3 = 0;
            int num4 = 2;

            int n = SumNumbers( ref num1, in num2, out num3, num4 );
            Console.WriteLine("SumNumbers = {0}", n);

        }
      
        static int SumNumbers(ref int num1, in int num2, out int num3, int num4 )
        {
            num1 = 6;
            num3 = num1 + num2;
            return num4 * num3;

        }


    }
}
