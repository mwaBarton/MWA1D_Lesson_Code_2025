using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L127___Ref2
{
    internal class Program
    {
        static void MyVerySimpleToUnderstandSubroutine(ref int num)
        {
            num = num + 1;

            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            int x = 1;

            MyVerySimpleToUnderstandSubroutine(ref x);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
