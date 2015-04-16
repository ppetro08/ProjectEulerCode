using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        private static Dictionary<long, BigInteger> cached = new Dictionary<long, BigInteger>();

        static BigInteger Fibonacci(long num)
        {
            if (cached.ContainsKey(num))
            {
                return cached[num];
            }
            if (num == 1 || num == 0)
            {
                return num;
            } else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
        static void Main(string[] args)
        {
            long counter = 1;
            BigInteger num = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (num.ToString().Length != 1000)
            {
                num = Fibonacci(counter);
                cached.Add(counter, num);
                //Debug.WriteLine("Number: {0} Fib: {1}", counter, num);
                counter++;
            }
            stopwatch.Stop();
            Console.WriteLine("Fibonacci number with 1000 #'s: {0}\nTime Elapsed: {1}", counter-1, stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
