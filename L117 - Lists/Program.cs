using System;
using System.Collections.Generic;

namespace L117___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> currencies;

            // 'new' creates an object
            currencies = new List<string>();

            currencies.Add("Pound");
            currencies.Add("Dollar");
            currencies.Add("Euro");
            currencies.Add("Rupees");

            currencies[0] = "Peso";

            Console.WriteLine(currencies[1]);

            Console.WriteLine(currencies.Count);

            if (currencies.Contains("Dollar"))
            {
                Console.WriteLine("Yes, there is the dollar");
            }

            // Remove item
            currencies.Remove("Euro");

            // Print the list
            foreach (string currency in currencies)
            {
                Console.Write(currency + ", ");
            }
        }
    }
}
