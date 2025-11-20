using System;
using System.IO;

namespace L126___Text_Files_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading from file
            string fileName = "food.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = "";
                while (!reader.EndOfStream && line != "bread")
                {
                    line = reader.ReadLine();

                    Console.WriteLine(line);
                }
            }

            // Writing to file
            using (StreamWriter writer = new StreamWriter("drinks.txt",false))
            {
                string message = "";
                while (message != "STOP")
                {
                    Console.Write("Enter a message or STOP: ");
                    message = Console.ReadLine();
                    if (message != "STOP")
                    {
                        DateTime time = DateTime.Now;
                        writer.WriteLine($"[{time}] {message}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
