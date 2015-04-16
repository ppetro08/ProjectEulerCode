using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowerDigitSum
{
    class Program
    {
        static BigInteger Power(int num, int power)
        {
            BigInteger multiply = 1;
            for (int i = 0; i < power; i++)
            {
                multiply *= num;
            }
            return multiply;
        }

        static void Main(string[] args)
        {
            double num = Math.Pow(2, 1000);
            Console.WriteLine("2^1000: {0}", Power(2, 1000));
            
            string e = Convert.ToString(Power(2, 1000));
            Console.WriteLine("Length: {0}", e.Length);
            char[] m = e.ToCharArray();
            double total = 0;
            for (int i = 0; i < m.Length; i++)
            {
                total += Char.GetNumericValue(m[i]);
            }
            Console.WriteLine("Sum of numbers: {0}", total);
            Console.ReadKey();
        }
    }
}
