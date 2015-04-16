using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LongestCollatz
{
    class Program
    {
        private static Dictionary<long, long> cached = new Dictionary<long, long>();
        // Finds the length of the chain
        static long sequence(long value)
        {
            long start_val = value; // keeps number value
            long counter = 1;
            while (value != 1)
            {
                // Checks for the cached number
                if (cached.ContainsKey(value))
                {
                    counter += cached[value];
                    return counter;
                }
                // Even rule
                if (value % 2 == 0)
                {
                    value = value / 2;
                } else // Odd Rule
                {
                    value = (value * 3) + 1;
                }
                counter++;
            }
            // Adds the number to the cache
            if (!cached.ContainsKey(start_val))
            {
                cached.Add(start_val, counter);
            }
            return counter;
        }

        static void Main(string[] args)
        {
            long seq = 0;
            int largest = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 13; i < 1000000; i++)
            {
                long num = sequence(i); // gets senquence length
                if (num > seq)
                {
                    seq = num; // Sets sequence length
                    largest = i; // Sets number that had the largest sequence length
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Largest Collatz sequence: {0}\nTime Elapsed: {1}", largest, stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
