using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to find the sum of numbers from 1 to N.

    internal class Sum_1_to_N
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i=0; i<=num; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);
        }
    }
}
