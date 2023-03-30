using System;
using System.Threading.Channels;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                //
            }

            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null;
            Console.WriteLine(c.X);
        }

        static void PassByRefDemo()
        {

            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();


            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swaped a={a}, b={b}");

        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

        }
    }
}