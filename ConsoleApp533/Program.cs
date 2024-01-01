using System;

namespace ConsoleApp533
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            ChangeAge( ref age);
            Console.WriteLine("Ваш возраст {0}", age);

        }

        static void ChangeAge( ref int age )
        {
            Console.WriteLine("Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());

        }


    }
}
