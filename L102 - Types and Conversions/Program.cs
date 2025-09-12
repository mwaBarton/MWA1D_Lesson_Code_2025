using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L102___Types_and_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = (int) Math.Round(6.5,MidpointRounding.AwayFromZero);

            //int yourNum = (int) (myNum * 2.1);

            Console.WriteLine(myNum);

            string name = "Max";

            char c = name[2];
            c = 'g';

            bool b = false;
            Console.Write("Are you sure? ");
            string input = Console.ReadLine();

            //if (input == "yes")
            //{
            //    b = true;
            //} else
            //{
            //    b = false;
            //}

            b = input == "yes";

            // Parsing
            int x = int.Parse("32");
            double y = double.Parse("6.7");
            bool z = bool.Parse("True");

            string s;

            s = x.ToString();
            Console.WriteLine(x);

            Console.WriteLine(c);
        }
    }
}
