using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to reverse a number.
    internal class ReverseNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while(num > 0)
            {
                int digit = num % 10;
                rev = rev*10 + digit;
                num = num / 10;
            }

            Console.WriteLine($"The reverse of give number is:{rev}");

        }
    }
}
