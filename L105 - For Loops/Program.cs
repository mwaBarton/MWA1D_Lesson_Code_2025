using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int bob = -10; bob < 10; bob = bob - 2)
            {
                Console.WriteLine(3 * bob);
            }

            Console.WriteLine("done.");
        }
    }
}
