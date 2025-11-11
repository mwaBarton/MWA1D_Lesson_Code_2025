using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L122___Structures
{
    public struct Movie
    {
        public string title;
        public double runTime;
        public int releaseYear;
    }

    internal class Program
    {
        static void PrintMovie(Movie M)
        {
            if (M.releaseYear != -1) Console.WriteLine($"{M.title}, Run Time: {M.runTime}mins");
            else Console.WriteLine("Error");
        }

        static Movie InputMovie()
        {
            Movie movie;

            Console.Write("Title: ");
            movie.title = Console.ReadLine();
            Console.Write("Run Time: ");
            movie.runTime = double.Parse(Console.ReadLine());
            Console.Write("Release year: ");
            movie.releaseYear = int.Parse(Console.ReadLine());

            return movie;
        }

        static void Main(string[] args)
        {
            Movie movie1;

            movie1.title = "Austin Powers";
            movie1.runTime = 120;
            movie1.releaseYear = 2000;

            PrintMovie(movie1);

            Movie movie2;

            movie2 = InputMovie();

            PrintMovie(movie2);

            Console.ReadKey();
        }
    }
}
