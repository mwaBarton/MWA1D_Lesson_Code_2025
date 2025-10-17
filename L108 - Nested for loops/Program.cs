using System;

namespace L108___Nested_for_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerI = 10, playerJ = 10;


            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (i == playerI && j > playerJ)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("O");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                playerI += 1;
            }


        }
    }
}
