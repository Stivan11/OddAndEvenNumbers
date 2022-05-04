using System;
using System.Linq;
using System.Collections.Generic;

namespace OddAndEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rnd = new Random();
            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int random = rnd.Next(1, 101);
                queue.Enqueue(random);
            }

            var even = new List<int>();
            var odd = new List<int>();

            while (queue.Any())
            {
                int currentNumber = queue.Dequeue();

                if (currentNumber % 2 == 0)
                {
                    even.Add(currentNumber);
                }
                else
                {
                    odd.Add(currentNumber);
                }
            }

            var merged = new List<int>();

            if (even.Count >= odd.Count)
            {
                for (int i = 0; i < even.Count; i++)
                {
                    merged.Add(even[i]);
                    if (i < odd.Count)
                    {
                        merged.Add(odd[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < odd.Count; i++)
                {
                    if (i < even.Count)
                    {
                        merged.Add(even[i]);
                    }
                    merged.Add(odd[i]);
                }
            }

            Console.WriteLine(string.Join(" ", merged));

        }
    }
}
