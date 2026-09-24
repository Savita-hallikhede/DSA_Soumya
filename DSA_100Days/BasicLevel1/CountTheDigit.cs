using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to count the digits of a number.
    internal class CountTheDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while(count != 0)
            {
                num = num / 10;
                count++;
                
            }

            Console.WriteLine(num);
            
        }
    }
}
