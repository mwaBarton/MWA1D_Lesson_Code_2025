using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L157___Subtype_Polymorphism
{
    public class Shape
    {
        public virtual double getArea()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        protected int side;

        public Square(int sideLength)
        {
            side = sideLength;
        }

        public override double getArea()
        {
            return side * side;
        }
    }

    public class SillySquare : Square
    {
        public SillySquare(int sideLength) : base(sideLength)
        {
        }

        public override double getArea()
        {
            return side * side + 1;
        }
    }

    public class Circle : Shape
    {
        private int radius;
        
        public Circle(int inRadius)
        {
            radius = inRadius;
        }

        public override double getArea()
        {
            return radius * radius * Math.PI;
        }
    }


    internal class Program
    {

        static void PrintShapeArea(Shape s)
        {
            Console.WriteLine(s.getArea());
        }

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square(4));
            shapes.Add(new Square(5));
            shapes.Add(new Square(6));
            shapes.Add(new Circle(4));
            shapes.Add(new SillySquare(4));


            foreach (Shape shape in shapes)
            {
                PrintShapeArea(shape);
            }

            Console.ReadKey();
        }
    }
}
