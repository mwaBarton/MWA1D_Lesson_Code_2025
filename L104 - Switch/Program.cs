using System;

namespace L104___Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your height (in 60ths of the average height): ");
            int height = int.Parse(Console.ReadLine());

            switch (height)
            {
                case 0:
                    Console.WriteLine("You are a pancake.");
                    break;
                case 60:
                    Console.WriteLine("average. boring!");
                    break;
                default:
                    Console.WriteLine($"Your height is {height} 60ths.");
                    break;
            }
        }
    }
}
