using System;
using System.Collections.Concurrent;
using System.Threading.Channels;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack();
        }

        static void MyStack()
        {
            var ms = new MyStack<int>();


            ms.Push(1);
            ms.Push(2);
            ms.Push(3);



            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());



            Console.ReadLine();
        }

        static void ProblemOfRepresentative()
        {
            IShape recr = new Rect() { Height = 2, Width = 5 };
            IShape square = new Square() { SideLength = 10 };




            Console.ReadLine();
        }

        static void MModelXTerminalain()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");

            terminal.Connect();

            Console.ReadLine();
        }

        static void BoxingUnboxing()
        {
            //int x = 1;
            //object obj = x;

            //int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)obj1;
            Console.WriteLine(number);
        }

        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do smth.
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                //do smth.
            }
        }

        static void ValRefTypesDemo()
        {

            EvilStruct es1 = new EvilStruct();
            //es1.PointRef = new PointRef() {X = 1, Y = 2};
            //es1.PointRef.X = 1;
            //es1.PointRef.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X}, es1.PointRef.Y={es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X}, es2.PointRef.Y={es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;


            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X}, es1.PointRef.Y={es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X}, es2.PointRef.Y={es2.PointRef.Y}");

            Console.WriteLine();

            PointVal a;

            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs.");

            PointRef c = new PointRef();
            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;


            c.LogValues();
            d.LogValues();

        }

        static void NRE_NullableValTypesDemo()
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

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swaped a={a}, b={b}");

        }
    }
}