﻿using System;

namespace ConsoleApp515
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] favcolors = new string[ 3 ];            

            for ( int i = 0; i < 3; i++)
                favcolors[i] = ShowColor();

            Console.WriteLine("Ваши любимые цвета на английском с маленькой буквы");
            foreach (var color in favcolors)
                Console.WriteLine(color);
                



        }

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



    }
}
