using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to check whether a number is a palindrome.
    //A palindrome is a number that remains the same when its digits are reversed.
    internal class CheckPalindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int rev = 0;

            while(num > 0)
            {
                int digit = num % 10;
                rev = rev*10+ digit;
                num = num / 10;

            }

            if (rev == original)
            {
                Console.WriteLine($"The given number {original}is Palindrome ");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }


        }
    }
}
