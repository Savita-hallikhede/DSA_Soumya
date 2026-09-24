using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_100Days.Day2
{
    //Write a program to check whether a number is an Armstrong number.
    internal class CheckArmstrong
    {
        //An Armstrong number is a number in which the sum of the cubes of its digits is equal to the original number.eg:153,370, 371, 407.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int sum = 0;

            while (num != 0)
            {
                int digit = num % 10;
                int mul = digit * digit * digit;
                sum = sum + mul;
                num = num / 10;

            }
            if (sum == original)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("not Armstrong Number");
            }


        }
    }
}
