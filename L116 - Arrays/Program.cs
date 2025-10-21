using System;

namespace L116___Arrays
{
    internal class Program
    {
        static void StupidestSubroutine(int i)
        {
            Console.WriteLine(i);
            StupidestSubroutine(i+1);
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }

        static void Main(string[] args)
        {
            StupidestSubroutine(1);

            int[] dougnutBoxSizes = new int[5];

            // The boring way
            dougnutBoxSizes[0] = 1;
            dougnutBoxSizes[1] = 2;
            dougnutBoxSizes[2] = 3;
            dougnutBoxSizes[3] = 4;
            dougnutBoxSizes[4] = 5;

            // The 'cool' way
            dougnutBoxSizes = new int[] { 1, 2, 3, 4, 5 };

            // Looops
            for (int i = 0; i < dougnutBoxSizes.Length; i++)
            {
                Console.Write("Enter size of dougnut box " + i + ": ");
                dougnutBoxSizes[i] = int.Parse(Console.ReadLine());
            }
            
            PrintIntArray(dougnutBoxSizes);
        }
    }
}
