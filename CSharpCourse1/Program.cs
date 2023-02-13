// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Text;
using System.Threading.Channels;
using System.Xml.Schema;

namespace CSarpCourse1
{
    class Program
    {

        static void DateTimeType()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now);
            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28); // defailt 00:00:00
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);
            Console.WriteLine(now.Subtract(newDt).ToString());
            TimeSpan ts = now - dt;
            Console.WriteLine(ts.ToString());

            ts = now.Subtract(dt);
            Console.WriteLine(ts.Days.ToString());

        }

        static void IntToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, -2, 5, 10 };

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            int massLength = a4.Length;

            Console.WriteLine(massLength);
            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char firstChar = s1[0];
            char lastChar = s1[s1.Length - 1];

            Console.WriteLine($"string: '{s1}' / fistChar: '{firstChar}' / lastChar: '{lastChar}'");
            s1 = s1.Remove(0, 1).Insert(0, "z");
            Console.WriteLine(s1);

             

        }

        static void MathDemo()
        {
            Console.WriteLine($"{Math.PI} - {Math.E} - {Math.Tau}");
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));


        }

        static void CastingAndParsing()
        {
            byte b = 3; // 0000 0011
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i; // 3.0

            Console.WriteLine(i);

            b = (byte)i;
            Console.WriteLine(b);

            i = (int)f;
            Console.WriteLine(i);

            f = 3.6f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine($"Parsed i={i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);

        }

        static void ConsoleBasics()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hi, please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age.");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence1 = $"Your age is {age}";
            Console.WriteLine(sentence1);

            //Console.Clear(); // For Clear Console
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;


        }

        static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);


            string str11 = "Strasse"; // German
            string str12 = "Straße";

            bool areEqual2 = string.Equals(str11, str12, StringComparison.Ordinal);
            Console.WriteLine(areEqual2);
            areEqual2 = string.Equals(str11, str12, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual2);
            areEqual2 = string.Equals(str11, str12, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual2);

        }

        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm  {1}", name, age);
            string str22 = "My name" + "is " + name + "and I'm " + age;
            string str2 = $"My name is {name} and I'm  {age}";

            string str3 = "My name is \n John";
            string str4 = "I'm \t30";

            str3 = $"My name is {Environment.NewLine} John";

            string str5 = "I'm John and i'm a \"good\" programmer";
            string str6 = "C:\\tmp\\test.txt";
            str6 = @"C:\tmp\test.txt";

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);


            double ans = 42.23;
            result = string.Format("{0:f}", ans);
            result2 = string.Format("{0:f4}", ans);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C4}", money);

            // Console.WriteLine(money.ToString("C4"));

            result = $"{money:C4}";

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); // izmeniaet valiutu drugoi strani

            Console.WriteLine(result2);


             

        }

        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is "); 
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(sb);
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
