using System;
using System.Collections.Generic;
using System.Linq;

namespace L120___Lists_2
{
    internal class Program
    {
        // List Printer
        static void printList(List<string> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        // Remove duplicates
        static void InputListWithNoDuplicates(List<string> list) {
            string input = "";
            while (input != "done")
            {
                Console.Write("Enter next name, or 'done' to stop: ");
                input = Console.ReadLine();

                if (input != "done")
                {
                    if (list.Contains(input))
                    {
                        Console.WriteLine("Duplicate detected and ignored.");
                    } else
                    {
                        list.Add(input);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Basics
            List<int> myList = new List<int>();
            myList.Add(6);
            myList.Add(-1);
            myList.Add(7);
            myList.Add(8);
            myList.Add(60);

            // List Printer
            List<string> shopping = new List<string> { "Eggs", "Flour", "Milk", "Butter" };
            printList(shopping);

            // Array to list
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            List<int> numsAsList = new List<int>();
            foreach (int i in nums)
            {
                numsAsList.Add(i);
            }

            // List to array
            int[] numsAsListAsArray = new int[numsAsList.Count];
            for (int i = 0; i < numsAsList.Count; i++)
            {
                numsAsListAsArray[i] = numsAsList[i];
            }

            // Remove duplicates
            List<string> uniques = new List<string>();
            InputListWithNoDuplicates(uniques);
            Console.WriteLine($"There are {uniques.Count} unique names:");
            printList(uniques);

            // Split string into a list
            Console.Write("Enter a string of words with spaces in between: ");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            List<string> wordsList = new List<string>();
            foreach (string word in words)
            {
                wordsList.Add(word);
            }
            printList(wordsList);

            // List difference
            Console.Write("Enter another string of words with spaces in between: ");
            string phrase2 = Console.ReadLine();
            string[] words2 = phrase2.Split(' ');
            List<string> wordsList2 = new List<string>();
            foreach (string word in words2)
            {
                wordsList2.Add(word);
            }

            foreach (string word in wordsList2)
            {
                while (wordsList.Contains(word))
                {
                    wordsList.Remove(word);
                }
            }
            printList(wordsList);

            Console.ReadKey();
        }
    }
}
