using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L125___Text_Files_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shoes = File.ReadAllText("Shoes.txt");
            //Console.WriteLine(shoes);

            string[] shoeLines = File.ReadAllLines("Shoes.txt");
            for (int i = 0; i < shoeLines.Length; i++)
            {
                string line = shoeLines[i];

                if (line.ToLower().Contains("left"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else if (line.ToLower().Contains("right"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(line);

                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Writing files
            for (int i = 0;i < shoeLines.Length; i++)
            {
                if (shoeLines[i].ToLower().Contains("right"))
                {
                    shoeLines[i] = "A LEFT SHOE!!!!!";
                }
            }
            File.WriteAllLines("Shoes.txt", shoeLines);

            File.WriteAllText("myFirstFile.txt", "Hello, World!");
            

            Console.ReadKey();
        }
    }
}
