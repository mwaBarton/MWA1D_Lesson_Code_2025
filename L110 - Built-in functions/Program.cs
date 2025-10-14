using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L110___Built_in_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            // Length
            Console.WriteLine(s.Length);

            // Case
            string newString = s.ToUpper();
            Console.WriteLine(newString);

            newString = s.ToLower();
            Console.WriteLine(newString);

            // Substring 
            newString = s.Substring(3, 5);
            Console.WriteLine(newString);

            // Index of
            Console.WriteLine(s.IndexOf("lo Wo"));
        }
    }
}
