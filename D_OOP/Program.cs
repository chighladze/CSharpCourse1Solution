namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            c.Hit(10);

            Console.WriteLine(c.Health);

        }
    }
}