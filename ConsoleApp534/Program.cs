using System;

namespace ConsoleApp534
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Олег";
            ChangeName(ref name);
            Console.WriteLine("Ваше имя {0}", name);

        }

        static void ChangeName(ref string name)
        {
            Console.WriteLine("Ваше имя");
            name = Console.ReadLine();

        }


    }
}
