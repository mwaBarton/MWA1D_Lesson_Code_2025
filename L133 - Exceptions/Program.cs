using System;

namespace L133___Exceptions
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (scorePercentage >= 80) return 'A';
            else if (scorePercentage >= 70) return 'B';
            else if (scorePercentage >= 0) return 'U';

            return 'X'; // Should never happen
        }

        static void Main(string[] args)
        {
            int score = 0;
            bool scoreOkay = false;

            while (!scoreOkay)
            {
                Console.Write("Enter score: ");
                try
                {
                    score = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your grade is {GradeCalculator(score)}");
                    scoreOkay = true;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error when entering score, please enter an integer.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error when entering score, please enter a valid percentage (0-100).");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            
        }
    }
}
