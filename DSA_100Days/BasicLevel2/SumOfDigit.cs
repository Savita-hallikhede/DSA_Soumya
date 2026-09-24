using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the sum of digits of a number.
    internal class SumOfDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit:");
            int digit = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while(digit != 0)
            {
                int d = digit % 10;
                sum = sum + d;
                digit = digit / 10;
            }
            Console.WriteLine("Sum of the digit:"+sum);
        }
    }
}
