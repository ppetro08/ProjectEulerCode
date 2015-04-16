using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialDigitSum
{

    class Program
    {
        static BigInteger Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            BigInteger b = Factorial(100);
            string jim = b.ToString();
            double sum = 0;

            for (int i = 0; i < jim.Length; i++)
            {
                sum += Char.GetNumericValue(jim[i]);
            }

            Console.WriteLine("100! = {0}\n", jim);
            Console.WriteLine("\nSum Factorial of 100 is: {0}", sum);
            Console.ReadKey();
        }
    }
}
