using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProduct
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            int largest = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if ((i*j).ToString() == ReverseString((i*j).ToString()) && (i*j) > largest)
                    {
                        largest = i * j;
                    }
                }
            }
            Console.WriteLine("Largest Palindrome: " + largest);
            Console.ReadKey();
        }
    }
}
