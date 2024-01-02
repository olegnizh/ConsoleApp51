using System;

namespace ConsoleApp538
{
    class Program
    {
        static void Main(string[] args)
        {

            int nums = 6;
            var result = GetArrayFromConsole( ref nums );

            foreach (var index in result)
                Console.Write(index.ToString() + " ");



        }

        static int[] GetArrayFromConsole(ref int nums)
        {
            var result = new int[ nums ];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[ i ] = int.Parse(Console.ReadLine());
            }

            return result;
        }




    }
}
