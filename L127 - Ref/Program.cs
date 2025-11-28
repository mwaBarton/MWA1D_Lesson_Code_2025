using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L127___Ref
{
    internal class Program
    {
        static void MyVeryComplicatedSubroutine(List<int>[] nums)
        {
            nums[0][0] = 2;

            Console.WriteLine(nums[0][0]);
        }

        static void Main(string[] args)
        {
            List<int>[] x = new List<int>[] { 
                new List<int>() { 1 }, 
                new List<int>() { 2 } 
            };

            List<int>[] xToPass = new List<int>[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                xToPass[i] = new List<int>();
                for (int j = 0; j < x[i].Count; j++)
                {
                    xToPass[i].Add(x[i][j]);
                }
            }

            MyVeryComplicatedSubroutine(xToPass);

            Console.WriteLine(x[0][0]);

            Console.ReadKey();
        }
    }
}
