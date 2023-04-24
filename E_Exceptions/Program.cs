using System;
using System.Text;

namespace E_Exceptions
{
    //custom exception type
    public class CreditCardWithdrawException : Exception
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void FileDemo()
        {
            //IEnumerable<string> lines = File.ReadLines("text.txt");


            File.WriteAllText("text_2.txt", "My name is John");
            File.WriteAllLines("text_3.txt", new string[] {"My name", "is John"});
            File.WriteAllBytes("text_4.txt", new byte[] {72, 101, 108, 108, 111});


            string allText = File.ReadAllText("text_2.txt");
            Console.WriteLine(allText);

            string[] allLines = File.ReadAllLines("text_3.txt");
            Console.WriteLine(allLines[0]);
            Console.WriteLine(allLines[1]);

            byte[] bytes =  File.ReadAllBytes("text_4.txt");
            Console.WriteLine(Encoding.ASCII.GetString(bytes));



            Console.ReadLine();

            Stream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                string str = "Hello, World";
                byte[] strInBytes = Encoding.ASCII.GetBytes(str);

                if (fs.CanWrite)
                {
                    fs.Write(strInBytes, 0, strInBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("Now reading");

            using (Stream readingStream = new FileStream("text.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] temp = new byte[readingStream.Length];

                int bytesToRead = (int)readingStream.Length;
                int bytesRead = 0;

                while (bytesToRead > 0)
                {
                    int n = readingStream.Read(temp, bytesRead, bytesToRead);

                    if (n == 0)
                    {
                        break;
                    }

                    bytesRead += n;
                    bytesToRead -= n;

                }

                string str = Encoding.ASCII.GetString(temp, 0, temp.Length);

                Console.WriteLine(str);

                Console.ReadLine();
            }
        }

        static void ExceptionDemo()
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Dispose();
                }
            }

            Console.ReadLine();

            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();

            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (OverflowException ex)
            {

            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exceptions has occurred.");
                Console.WriteLine("Information is below:");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(number);
        }
    }
}