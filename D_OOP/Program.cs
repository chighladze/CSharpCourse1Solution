namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            c.Hit(99);

            Console.WriteLine(c.Health);

        }
    }
}