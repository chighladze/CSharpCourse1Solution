using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP.Homeworks
{
    internal class Complex
    { 
        public double Imaginary { get; set; }
        public double Real {get; set; }

        public Complex(double imaginary, double real)
        {
            Imaginary = imaginary;
            Real = real;
            
        }

        private Complex(){}

        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary + Imaginary;
            complex.Real = other.Real - Real;

            return complex;
        }

        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary - Imaginary;
            complex.Real = other.Real - Real;

            return complex;
        }
    }
}
