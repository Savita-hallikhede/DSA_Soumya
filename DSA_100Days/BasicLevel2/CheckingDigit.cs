using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to check whether a number contains a particular digit.

    internal class CheckingDigit
    {
        public static void Main(string[] args)
        {
            int a = 123456;
            Console.WriteLine("Enter the digit:");
            int digitToCeck = Convert.ToInt32(Console.ReadLine());


            while (a > 0)
            {
                int num = a % 10;
                if(num == digitToCeck)
                {
                    Console.WriteLine("digit is present");
                }

                a = a/ 10;
            }
        }
    }
}
