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
}
