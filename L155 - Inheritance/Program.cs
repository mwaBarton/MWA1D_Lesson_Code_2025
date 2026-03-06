using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L155___Inheritance
{
    public class Rectangle
    {
        private int width, height;
        public Rectangle(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
        }

        public Rectangle()
        {
            width = 10;
            height = 10;
        }

        public virtual int getArea()
        {
            return width * height;
        }
    }

    public class Square : Rectangle
    {
        public string name;

        public Square(int sideLength, string inName) : base(sideLength, sideLength)
        {
            name = inName;
        }

        public override int getArea()
        {
            return name.Length;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3, 4);

            Rectangle r2 = new Square(5, "Jonathan");

            Square itsActuallyASquare = (Square) r2;


            Console.WriteLine(r2.getArea());
            Console.WriteLine(itsActuallyASquare.getArea());


            Console.ReadKey();
        }
    }
}
