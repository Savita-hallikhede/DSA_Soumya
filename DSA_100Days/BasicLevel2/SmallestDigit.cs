using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the largest digit in a number.

    internal class SmallestDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int smallest = 9;
            while(num != 0)
            {
                int digit = num % 10;
                if (digit < smallest)
                {
                    smallest = digit;
                }
                num /= 10;
            }
            Console.WriteLine("Smallest number is:" + smallest);
        }
    }
}
