using System;

namespace ConsoleApp558
{
    class Program
    {
        static void Main(string[] args)
        {

			int x = PowerUp(2, 5);
            Console.WriteLine("Получилось {0}", x);
            Console.ReadKey();
        }

		public static int PowerUp(int N, byte pow)
		{
			byte d = 1;
			if (pow == 0)
			{
				return 1;
			}
			else
			{
				if (pow == 1)
				{
					return N;
				}
				else
				{
					return N * PowerUp(N, --pow);
				}
			}
		}


	}
}
