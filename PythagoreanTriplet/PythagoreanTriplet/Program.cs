using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class PythagoreanTriplet
    {
        private const int d = 1000;
        private double a = 0;
        private double b = 0;
        private double c = 0;

        public PythagoreanTriplet()
        {
            loopThrough();
        }

        public bool isLessThan()
        {
            if (a < b && b < c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isPythagorean()
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isThousand()
        {
            if (a + b + c == 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getABC()
        {
            string str = a.ToString() + b.ToString() + c.ToString();
            return str;
        }
        public void loopThrough()
        {
            double m = 1;
            double n = 0;
            while (!isLessThan() || !isPythagorean() || !isThousand())
            {
                a = Math.Pow(m, 2) - Math.Pow(n, 2);
                b = 2 * m * n;
                c = Math.Pow(m, 2) + Math.Pow(n, 2);
                m++;
                n++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PythagoreanTriplet pyth = new PythagoreanTriplet();
            Console.WriteLine(pyth.getABC());
            Console.ReadKey();
        }
    }
}
