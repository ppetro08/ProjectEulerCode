using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int factors = 0;
            int num = 1;

            while (factors <= 500)
            {
                factors = 0;
                int tnum = num * (num + 1) / 2;
                int sqrt = (int)Math.Sqrt(tnum);

                for (int i = 1; i <= sqrt; i++)
                {
                    if (tnum % i == 0)
                    {
                        factors += 2;
                    }
                }
                if (sqrt * sqrt == tnum)
                {
                    factors++;
                }
                num++;
            }
            num--;
            stopwatch.Stop();
            Console.WriteLine("Number with 500 factors: {0}", num * (num + 1) / 2);
            Console.WriteLine("Took {0} ms to run", stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
