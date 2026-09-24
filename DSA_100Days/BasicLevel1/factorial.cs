using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to find the factorial of a number.

    internal class factorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for(int i=0; i<= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }
    }
}
