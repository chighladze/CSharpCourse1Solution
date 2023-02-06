﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Threading.Channels;
using System.Xml.Schema;

namespace CSarpCourse1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textData = File.ReadAllText("C:\\Users\\gioch\\OneDrive\\Desktop\\123123.txt");
            Console.WriteLine(textData);

        }

        static void StringModification() 
        {
            string nameConcat = string.Concat('M', 'y', ' ', "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            //string newName
            string newName = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(newName);

            string remove = nameConcat.Remove(0, 1);
            Console.WriteLine(remove);

            string replace = nameConcat.Replace('n', 'z');
            Console.WriteLine(replace);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }

        static void StringEmptiness()
        {
            string empty = "";
            string whiteSpace = " ";
            string notEmpty = " b";
            string nullString = null;


            Console.WriteLine("IsNullOrEmpty");
            bool IsNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(whiteSpace);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsNullOrEmpty);

            IsNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullOrEmpty);

            bool TrueOrFalse = empty == nullString;
            Console.WriteLine(TrueOrFalse);

            TrueOrFalse = null == nullString;
            Console.WriteLine(TrueOrFalse);

            Console.WriteLine();
            Console.WriteLine("IsNullOrwhiteSpace");

            bool IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(whiteSpace);
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrwhiteSpace);

        }

        static void QueryngStrings()
        {
            int x = 1;
            string name = "abrakadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine($"1: {containsA} / 2: {containsE}");

            string abc = string.Concat('a', 'b', 'c');
            Console.WriteLine(abc);


            Console.WriteLine(int.MinValue);


            bool endWithAbra = name.EndsWith("abra");
            Console.WriteLine(endWithAbra);

            bool startWithAbra = name.StartsWith("abra");
            Console.WriteLine(startWithAbra);

            int indexOfA = name.IndexOf('a');
            Console.WriteLine(indexOfA);
            indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndxOfR = name.LastIndexOf('r');

            Console.WriteLine(name.Length);


        }

        static void CompresionOperators()
        {
            int x = 1;
            int y = 2;

            bool areaEqual = x == y;
            Console.WriteLine(areaEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);


        }

        static void MathOperations()
        {
            int x = 1;
            int y = 2;
            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);

            a *= 2; // a = a * 2;
            Console.WriteLine(a);

            a /= 2; // a = a/ 2;
            Console.WriteLine(a);




        }

        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;
            Console.WriteLine(x);

            x++; //postfiksnaia zappis
            Console.WriteLine(x);

            ++x; //infiksnaia zapis
            Console.WriteLine(x);

            x = x - 1;
            Console.WriteLine(x);

            x--;
            Console.WriteLine(x);

            --x;
            Console.WriteLine(x);


            Console.WriteLine("Learn about increnebts");
            Console.WriteLine($"Last x sate is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2; // eto toje samoie chto i x = x + 2
            Console.WriteLine(x);

            j -= 2; // eto toje samoie chto i j = j -2
            Console.WriteLine(j);





        }

        static void Overflow()
        {

            checked
            {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            x = x + 1;
            Console.WriteLine(x);
            x = x + 3;
            Console.WriteLine(x);
            }
        }

        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //console.writeline(c); - это значение не находится в области видимости
            }
        }

        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            x = 0x1f;
            x = 0xff0d;
            k = 0x1fab30ef;
            m = 0x1fab_30ef;

            Console.WriteLine();


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
        }

        static void Variables()
        {
            int x = -1 * 102334546;
            int y;
            y = 2;
            // int32 x = -1;

            // uint z = -1; так значение не может быть записсанна так как в uint не может быт записанно отрицательное число

            float f = 1.1f;
            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            Dictionary<int, string> dict = new Dictionary<int, string>();

            var dict1 = new Dictionary<int, string>();

            decimal money = 3.0m;
            char character = 'a';
            string name = "john";

            bool candrive = true;
            bool candraw = false;

            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);







            //console.backgroundcolor = consolecolor.green;
               
            Console.WriteLine();
        }

    }
} 
