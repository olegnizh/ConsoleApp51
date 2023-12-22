using System;

namespace ConsoleApp512
{
    class Program
    {

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static void Main(string[] args)
        {

            (string name, int age) user = ("Олег", 27);

            Console.WriteLine("Мое имя: {0}", user.name);
            Console.WriteLine("Мой возраст: {0}", user.age);

            Console.Write("Введите имя: ");
            user.name = Console.ReadLine();
            Console.Write("Введите возрас с цифрами:");
            user.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", user.name);
            Console.WriteLine("Ваш возраст: {0}", user.age);

            Console.WriteLine("Ваш любимый цвет на английском с маленькой буквы: {0}", ShowColor());
           

        }


    }
}
