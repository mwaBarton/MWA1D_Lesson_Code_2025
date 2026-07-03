using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L185___Exceptions_2
{


    internal class Program
    {
        static Random rnd = new Random();

        static bool CookPizza(int complexity)
        {
            int num = rnd.Next(1, 30 + 1);
            //Console.WriteLine(num);
            if (num < complexity)
            {
                throw new PizzaBurntException("You burnt it really badly: "+(complexity - num));
            }

            return true;
        }

        static bool MakePizza(int numToppings)
        {
            int tries = 2;
            bool done = false;
            while (!done && tries > 0)
            {
                try
                {
                    int complexity = numToppings * numToppings;
                    done = CookPizza(complexity);
                }
                catch (PizzaBurntException ex)
                {
                    Console.WriteLine(ex.Message);
                    if (tries == 1)
                    {
                        Console.WriteLine("I give up. I can't cook pizza...");
                        throw;
                    } else
                    {
                        Console.WriteLine("Pizza was burnt. Trying again...");
                        tries--;
                    }
                        
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("How many toppings do you want? ");
            int toppings = int.Parse(Console.ReadLine());

            if (MakePizza(toppings))
            {
                Console.WriteLine("Success! Now eat it...");
            }
        }
    }
}
