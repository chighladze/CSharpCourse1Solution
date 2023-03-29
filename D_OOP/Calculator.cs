using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Calculator
    {
        public double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }

        public double Average2(params int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }



        public double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

            return square;
        }

        public double CalcTriangleSquare(double b, double h)
        {
            double square = 0.5 * b * h;

            return square;
        }

        public double CalcTriangleSquare(double ab, double ac, int alpha)
        {
            double rads = alpha * Math.PI / 180;

            return 0.5 * ab * ac * Math.Sin(rads);
        }
    }
}



