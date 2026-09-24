using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the largest digit in a number.

    internal class LargestDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());

            int largest = 0;
            
            while(num > 0)
            {
                int digit = num % 10;
                if (digit > largest)
                {
                    largest = digit;
                }
                num = num / 10;

            }
            Console.WriteLine("largest number is:"+largest);
        }
    }
}
