using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the product of digits of a number.

    internal class ProductOfDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int product = 1;
            while(num != 0)
            {
                int digit = num % 10;
                product = product * digit;
                num = num / 10;
            }

            Console.WriteLine("Product of the Number is:" + product);
        }
    }
}
