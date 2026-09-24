using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to check whether a string is a palindrome.

    internal class CheckPalindromeString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            string original = name;

            string rev = "";

            for(int i=name.Length-1; i>=0; i--)
            {
                rev = rev+ name[i];
            }
            if(rev == original)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }

        }
    }
}
