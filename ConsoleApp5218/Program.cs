using System;

namespace ConsoleApp5218
{
    class Program
    {

        static void Main(string[] args)
        {

            var array = GetArrayFromConsole();

            ShowArray(array, true);

        }

        static void ShowArray(int[] array, bool sorted = false)
        {
            var array1 = array;

            if (sorted)
                array1 = SortArray(array);

            foreach (var index in array1)
                Console.Write(index.ToString() + " ");

        }

        static int[] SortArray(int[] result)
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


        static int[] GetArrayFromConsole(int num = 10)
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

