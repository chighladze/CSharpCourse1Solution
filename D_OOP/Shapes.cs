using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public abstract class Shapes
    {
        public Shapes()
        {
            Console.WriteLine("Shape Creates");
        }

        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Triangle : Shapes
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac) : base()
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle Created");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }


    public class Rectangle : Shapes
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Created");
        }

        public override double Area()
        {
            return width * width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}
