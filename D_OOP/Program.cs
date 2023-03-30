using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PointVal a; // same as PintVal a = new PointVal();
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After struct");

            PointRef c = new PointRef();
            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            c.LogValues();
            d.LogValues();
        }
    }
}