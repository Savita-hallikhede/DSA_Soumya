using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to check whether a number is a perfect number.
    //A perfect number is a number where the sum of its factors (excluding the number itself) is equal to the number.
    //But for a perfect number, the definition says exclude the number itself
    internal class CheckPerfectNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i=1; i<num; i++)
            {
                if(num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == num)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
        }
    }
}
