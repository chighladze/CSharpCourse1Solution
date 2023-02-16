using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

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
