using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to find the largest of two numbers.
    internal class LargestNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine($"{num1} is the largest number");
            }
            else
            {
                Console.WriteLine($"{num2} is the largest number");
            }
        }
    }
}
