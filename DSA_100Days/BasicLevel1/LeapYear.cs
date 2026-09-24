using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to check whether a year is a leap year.

    internal class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year%400 == 0 || year%4==0 && year%100==0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
