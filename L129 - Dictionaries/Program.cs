using System;
using System.Collections.Generic;

namespace L129___Dictionaries
{
    internal class Program
    {
        static void AnalyseText(string text)
        {
            string[] words = text.Split(' ');

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Add each new word to the dictionary, with a value of 1.
            // Existing words cause the count to increment


            // Find the most common word in the text and print it out
        }


        static void Main(string[] args)
        {
            AnalyseText("the quick brown fox jumps over the lazy dog");

            Dictionary<string, string> dict = new Dictionary<string, string>();

            // No duplicate keys
            dict.Add("food", "something you eat");
            dict.Add("shoe", "something you put on your foot");
            dict.Add("cow", "type of animal");
            dict.Add("chicken", "something Sam eats mostly");


            dict["food"] = "something that you consume";

            bool done = false;
            while (!done)
            {
                Console.Write("Enter a word (or DONE when you're done): ");
                string word = Console.ReadLine();

                if (word == "DONE")
                {
                    done = true;
                }
                else if (dict.ContainsKey(word))
                {
                    Console.WriteLine(dict[word]);
                }
                else
                {
                    Console.WriteLine($"{word} is a new word that doesn't exist in the English language.");
                    Console.Write($"What is the definition of {word}?: ");
                    string def = Console.ReadLine();
                    dict.Add(word, def);
                }

                Console.WriteLine("\n\n");
            }

            Console.WriteLine(dict.Count);



            // Search for word by it's definition
            Console.Write("Search definitions in the dictionary: ");
            string search = Console.ReadLine();

            foreach (string word in dict.Keys)
            {
                dict[word] = "42";
                //string def = dict[word];
                //if (def.Contains(search))
                //{
                //    // Match
                //    Console.WriteLine($"{word}: {def}");
                //}
            }

            Console.ReadKey();
        }
    }
}
