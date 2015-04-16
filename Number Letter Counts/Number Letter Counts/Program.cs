using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Number_Letter_Counts
{
    class Program
    {
        private static Dictionary<int, string> numbers = new Dictionary<int, string>()
        {
            {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"},
            {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"},
            {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}
        };

        static string TripleDigs(int num)
        {
            string numstring = num.ToString();
            int mod10 = num % 10;
            int mod100 = num % 100;
            if (num % 100 == 0)
            {
                numstring = numbers[Convert.ToInt32(numstring[0].ToString())] + "hundred";
            } else if (num % 100 > 20)
            {
                numstring = numbers[Convert.ToInt32(numstring[0].ToString())] + "hundredand" + DoubleDigs(Convert.ToInt32(numstring.Substring(1, numstring.Length - 1)));
            } else
            {
                numstring = numbers[Convert.ToInt32(numstring[0].ToString())] + "hundredand" + numbers[Convert.ToInt32(numstring.Substring(1, numstring.Length - 1))];
            }

            return numstring;
        }

        static string DoubleDigs(int num)
        {
            string numstring = num.ToString();
            int mod = num % 10;
            if (mod == 0)
            {
                numstring = numbers[num];
            } else
            {
                string tempstring = numstring[0].ToString() + "0";
                numstring = numbers[Convert.ToInt32(tempstring)] + numbers[mod];
            }
            return numstring;
        }

        static void Main(string[] args)
        {
            long total = 0;
            string returned = "";
            for (int i = 1; i <= 1000; i++)
            {
                if (i == 1000)
                {
                    returned = "onethousand";
                }
                else if (i > 99)
                {
                    returned = TripleDigs(i);
                } else if (i > 20)
                {
                    returned = DoubleDigs(i);
                } else
                {
                    returned = numbers[i];
                }
                //Debug.WriteLine("{0}: {1}", i, returned);
                total += returned.Length;
            }
            Console.WriteLine("Total: {0}", total);
            Console.ReadKey();
        }
    }
}
