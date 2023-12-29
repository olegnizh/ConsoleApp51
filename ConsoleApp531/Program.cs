using System;

namespace ConsoleApp531
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            ChangeAge( age );
            Console.WriteLine("Ваш возраст {0}", age);

        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());

        }


    }
}
