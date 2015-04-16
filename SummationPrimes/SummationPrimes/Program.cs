using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationPrimes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            long sum = 0;
            for (int i = 1; i < 2000000; i++)
            {
                if (CheckIfPrime(i) == true)
                    sum += i;
            }
            System.Console.WriteLine(sum);
            System.Console.Read();
        }

        static bool CheckIfPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }
    }
}
