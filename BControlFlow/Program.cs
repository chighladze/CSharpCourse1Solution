using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

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
                    if(numbers[i] == j)
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

            for (int i =0; i < numbers.Length - 2; i++)
            {
                for (int j = i +1; j < numbers.Length - 1; j++)
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
            for (int i = numbers.Length - 1; i >= 0; i-- )
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


            if (firstDigit > secondDigit) {
                Console.WriteLine($"First digit:{firstDigit} is greaten then Second digit:{secondDigit} ");
            }
            else if (firstDigit < secondDigit)
            {
                Console.WriteLine($"First digit:{firstDigit} is leese then Second digit:{secondDigit} ");
            }
            else {
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
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex  <= 30;
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

            if(isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            Console.WriteLine(description);
        }

    }
}
