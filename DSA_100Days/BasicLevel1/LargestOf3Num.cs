using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    // //Write a program to find the largest of three numbers.
    internal class LargestOf3Num
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is a largest number ");
            } else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is a largest number ");
            }
        }
    }
}
