namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 10, 10);
            double square2 = calc.CalcTriangleSquare(10, 10);
            Console.WriteLine($"Square1={square1}. Square2={square2}");

        }
    }
}