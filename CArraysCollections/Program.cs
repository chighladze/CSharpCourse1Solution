using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
        }

            static void StackQueue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Sould print out 1: {queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"Sould print out 2: {queue.Peek()}");

            Console.WriteLine("Iterate over the queue.");
            foreach (var cur in queue) 
            {
                Console.WriteLine(cur);
            }

            Console.ReadLine();


            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"should print out 4: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"should print out 3: {stack.Peek()}");

            Console.WriteLine($"Iterate over the stack.");
            foreach(var cur in stack)
            {
                Console.WriteLine(cur);
            }

        }

        static void Dictonary()
        {
            var peolpe = new Dictionary<int, string>();
            peolpe.Add(1, "John");
            peolpe.Add(2, "Bob");
            peolpe.Add(3, "Alice");

            peolpe = new Dictionary<int, string>()
            {
                {1, "John" },
                {2, "Bob" },
                {3,  "Alice" },
            };

            string name = peolpe[1];
            Console.WriteLine(name);

            var keys = peolpe.Keys;
            // Dictonary<int, string>.KeyCollection key = peolpe.Keys;
            foreach (var item in keys)
            {

                Console.WriteLine(item);
                Console.WriteLine($"key: {item}; value={peolpe[item]}");

            }

            var values = peolpe.Values;
            // Dictionary<int, string>.ValueCollection values = peolpe.Values;
            foreach (var v in values)
            {
                Console.WriteLine($"{v}");
            }


            foreach (var i in peolpe)
            {
                Console.WriteLine($"Key: {i.Key} / Value: {i.Value}");
            }
            Console.WriteLine($"Count={peolpe.Count}");

            bool containsKey = peolpe.ContainsKey(2);
            bool containsValue = peolpe.ContainsValue("John");

            Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}");

            var p = peolpe.Remove(1);

            if (peolpe.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added Succssfully");
            }
            else
            {
                Console.WriteLine($"Failed to add using key 2");
            }

            if (peolpe.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Filed to get");
            }

            peolpe.Clear();



        }

        static void ListDemo()
        {
            var inList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };
            inList.Add(7);

            int[] intArray = { 1, 2, 3 };
            inList.AddRange(intArray);

            if (inList.Remove(1)) // first occurence
            {
                // do
            }
            else { }



            inList.RemoveAt(0);

            inList.Reverse();

            bool contains = inList.Contains(3);

            int min = inList.Min();
            int max = inList.Max();

            Console.WriteLine($"Min={min}. Max={max}");

            int indexof = inList.IndexOf(2); // finde only first index
            int lastIndexOf = inList.LastIndexOf(2); // finde only last index
            Console.WriteLine($"IndexOf2={indexof}; lastIndexOf2={lastIndexOf}");

            for (int i = 0; i < inList.Count; i++)
            {
                Console.Write($"{inList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in inList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();




        }

        static void ArrayType()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);
            foreach (int c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (int c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();


            Array.Clear(copy, 0, copy.Length);


            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[10];
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, -2, 5, 10 };

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0);

            Console.WriteLine(myArray2.GetValue(0));


        }

    }
}
