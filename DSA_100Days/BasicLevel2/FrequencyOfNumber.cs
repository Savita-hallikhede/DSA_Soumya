using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to count how many times a particular digit occurs in a number.
    internal class FrequencyOfNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the digit to find their frequency:");
            int  digitToCount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if(digit == digitToCount)
                {
                    count++;
                }
                num = num / 10;
            }

            Console.WriteLine($"The digit{digitToCount} occured {count} times"); 
        }
    }
}
