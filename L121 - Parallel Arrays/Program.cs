using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L121___Parallel_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Student = new string[] {
                "Theo",
                "Josh",
                "Emily",
                "Sam"
            };
            int[] marks = new int[]
            {
                67,
                42,
                16,
                67
            };

            for (int i = 0; i < Student.Length; i++) {
                Console.WriteLine($"Student {Student[i]} scored {marks[i]} marks.");            
            }

            
        }
    }
}
