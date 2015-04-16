using System;
using System.IO;
using System.Numerics;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string line;
            BigInteger sum = new BigInteger();
            StreamReader file = new StreamReader(@"C:\BigSum.txt");
            while ((line = file.ReadLine()) != null)
            {
                sum += BigInteger.Parse(line);
            }
            file.Close();
            string result = sum.ToString();
            stopwatch.Stop();
            Console.WriteLine("first 10 digits: {0}", result.Substring(0, 10));
            Console.WriteLine("elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
