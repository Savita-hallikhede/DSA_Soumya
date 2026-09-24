using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to check whether a number is positive, negative, or zero.
    internal class Pos_Neg_Zero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine($"{num} : is positive number");
            }else if(num < 0)
            {
                Console.WriteLine($"{num} : is negetive number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
