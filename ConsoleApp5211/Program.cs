using System;

namespace ConsoleApp5211
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ваше имя");
            string username = Console.ReadLine();

            string[] favcolors = new string[ 3 ] { "cyan", "red", "green" };

            ShowColors( username, favcolors );


        }

        static void ShowColors( string username, params string[] favcolors )
        {

            for ( int i =0; i < 3; i++)
               Console.WriteLine(favcolors[ i ] + " ");

        }


    }
}
