using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favourite number: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 13)
            {
                Console.WriteLine("That's the same as Charlie's!");
            }
            else if (x < 13)
            {
                Console.WriteLine("That's less than Charlie's");
            }
            else
            {
                Console.WriteLine("That's more than Charlie's");
            }

            Console.ReadKey();
        }
    }
}
