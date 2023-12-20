using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {

            (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите пять названия любимых блюд");
            Console.WriteLine("");
            User.Dishes = new string[5];
            int numDishe;
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                numDishe = i + 1;
                Console.WriteLine("Введите название блюда номер {0}", numDishe);
                User.Dishes[i] = Console.ReadLine();
            }


        }
    }
}
