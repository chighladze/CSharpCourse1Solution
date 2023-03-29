using System.Threading.Channels;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // double square1 = calc.CalcTriangleSquare(10, 10, 10);
            // double square2 = calc.CalcTriangleSquare(10, 10);
            // Console.WriteLine($"Square1={square1}. Square2={square2}");

            //Console.WriteLine(RomanNumeral.Parse("LXIV"));
            //double square = calc.CalcTriangleSquare(10, 20, 50);
            //Console.WriteLine(square);

            //double avg = calc.Average2(1, 2, 3, 4 );
            //Console.WriteLine(avg);

            if (calc.TryDivide(10, 2, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Filed to divide.");
            }
            Console.ReadLine();



            Console.WriteLine("Enter a number, please.");

            string line = Console.ReadLine();

            
            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Filed to parse");
            }

        }
    }
}