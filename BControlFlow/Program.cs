using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UserAuth();
        }


        static void UserAuth()
        {
            Console.WriteLine("Please enter the Login & Password");
            Console.WriteLine();

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("login: ");
                string username = Console.ReadLine();

                Console.Write("pass: ");
                string password = Console.ReadLine();

                if (username == "johnsilver" && password == "qwerty")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the System");
                    break;
                }
                else if(username != "johnsilver" && password != "qwerty" && i == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("The number of available tries have been exceeded");
                    break;
                }

            }

        }

        static void FactorialOfNumber()
        {
            Console.Write("Enter the number whose factorial you want to calculate: ");
            int num = int.Parse(Console.ReadLine());

            int[] FactorialMassive = new int[num];

            for (int i = 0; i < FactorialMassive.Length; i++)
            {
                FactorialMassive[i] = num;
                num--;
            }

            long factorial = FactorialMassive[0];

            for (int i = 1; i < FactorialMassive.Length; i++)
            {
                factorial = factorial * FactorialMassive[i];
            }

            Console.WriteLine(factorial);

        }

        static void SumOfInts()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Please enter dont more than 10 positive integers, if you enter 0 or nothing you exit.");

            int count = 1;

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write($"enter val{count}: ");

                string v = Console.ReadLine();

                if (v == "0" || v == "")
                {
                    Console.WriteLine($"You are exit, entered {i} numbers.");
                    break;
                }
                else
                {
                    numbers[i] = int.Parse(v);
                }

                count = count + 1;

            }

            int sum = 0;
            int c2 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0 && numbers[i] != 0)
                {
                    sum = sum + numbers[i];
                    c2 = c2 + 1;

                }
            }

            Console.WriteLine((double)sum / (c2));

        }

        static void ConnToDb()
        {
            string database = "jarvisdb";

            string server = "localhost";
            string username = "root";
            string password = "root";

            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);

            conn.Open();
            string query = "SELECT * FROM ns_accounts";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["id"]} {reader["payID"]}");
            }


        }

        static void DebugingDemoExample()
        {
            Console.WriteLine("Let's calculate the square of a triagle.");
            Console.WriteLine("Enter the length of side AB:");
            double ab = GetDouble();

            Console.WriteLine("Enter the length of side BC:");
            double bc = GetDouble();

            Console.WriteLine("Enter the length of side AC:");
            double ac = GetDouble();

            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of the triagle equals {square}");
        }

        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static void SwithCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autum";
                    break;
                default:
                    throw new ArgumentException("Exception");
            }


            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "11111111111";
                    break;
                case 10:
                    name = "22222222222";
                    break;
                case 15:
                    name = "33333333333";
                    break;
                case 20:
                    name = "44444444444";
                    break;
                case 25:
                    name = "55555555555";
                    break;
                case 30:
                    name = "66666666666";
                    break;
                default:
                    name = "Dont know";
                    break;


            }

        }

        static void BreakContinue()
        {
            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                    {
                        break;
                    }
                    Console.Write($"{letters[j]}");
                }
                Console.WriteLine();
            }






            //int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };


        }

        static void WhileDoWhile()
        {
            DateTime startTime = DateTime.Now;

            int age = 20;

            while (age < 18)
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            age = 30;

            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
            Console.WriteLine("Good!");
            DateTime endTime = DateTime.Now;
            Console.WriteLine($"time: {endTime - startTime}");


        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {

                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }
                }
            }
        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }
            Console.WriteLine();
            foreach (int var in numbers)
            {
                Console.Write(var + " ");
            }




        }

        static void HomeWorkGetMax()
        {
            Console.Write("Please enter first digit: ");
            double firstDigit = double.Parse(Console.ReadLine());

            Console.Write("Please enter second digit: ");
            double secondDigit = double.Parse(Console.ReadLine());


            if (firstDigit > secondDigit)
            {
                Console.WriteLine($"First digit:{firstDigit} is greaten then Second digit:{secondDigit} ");
            }
            else if (firstDigit < secondDigit)
            {
                Console.WriteLine($"First digit:{firstDigit} is leese then Second digit:{secondDigit} ");
            }
            else
            {
                Console.WriteLine($"First digit:{firstDigit} is equal to Second digit:{secondDigit} ");
            }
        }

        static void BMI()
        {


            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your Weight(kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your Height(m): ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            double bodyMassIndex = weight / (height * height);

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape");
            }

            //if(isFat == false)
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            Console.WriteLine(description);
        }

    }
}
