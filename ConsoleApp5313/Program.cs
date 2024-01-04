using System;

namespace ConsoleApp5313
{
    class Program
    {

        const int array_length = 5;

        static void Main(string[] args)
        {
            // init             
            var array = GetArrayFromConsole( array_length );           
            // actions
            SortArray(in array, out array_a, out array_d);
            // view result
            Console.WriteLine("\n");
            Console.WriteLine("Массив - по возрастанию");
            ShowArray( ref array_a );
            Console.WriteLine("\n");
            Console.WriteLine("Массив - по убыванию");
            ShowArray( ref array_d );
            Console.WriteLine("\n");


        }

        static void ShowArray(ref int[] array)
        {
            foreach (var index in array)
                Console.Write(index.ToString() + " ");
        }

        static void SortArray(in int[] array, out int[] array_a, out int[] array_d)
        {
            array_a = new int[ array_length ];
            array_a = SortArrayAsc(array);
            array_d = new int[ array_length ];
            array_d = SortArrayDesc(array);

        }

        static int[] SortArrayAsc(int[] result)
        {

            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }


        static int[] SortArrayDesc(int[] result)
        {

            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }


        static int[] GetArrayFromConsole(int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }




    }
}
