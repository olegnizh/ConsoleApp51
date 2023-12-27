using System;

namespace ConsoleApp529
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] favcolors = new string[3];
            (string name, int age) anketa;

            Console.WriteLine("Укажите ваше имя");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Укажите ваш возраст");
            var sage = Console.ReadLine();
            anketa.age = Convert.ToInt32(sage);

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

            for (int i = 0; i < 3; i++)
                favcolors[ i ] = ShowColorLike(anketa.name, anketa.age);

            //ShowColors(favcolors[0], favcolors[2]);
            Console.WriteLine("Ваши любимые цвета:");            
            for (int k = 0; k < 3; k++)
            {
                if ((k == 0) || (k == 2))
                    Console.WriteLine(favcolors[ k ]);
            }

            


        }


        static string ShowColorLike(string username, int age)
        {
            Console.WriteLine("{0} {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, age.ToString());
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


    }
}
