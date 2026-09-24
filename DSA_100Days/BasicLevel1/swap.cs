using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to swap two numbers.
    internal class swap
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Before Swapping a=" + a);
            Console.WriteLine("Before Swapping b=" + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping a=" + a);
            Console.WriteLine("After Swapping b=" + b);

            //Without using temp 
            int a1 = 2;
            int b1 = 3;

            Console.WriteLine("Before Swapping a1=" + a1);
            Console.WriteLine("Before Swapping b1=" + b1);

            a1 = a1 + b1;
            b1= a1 - b1;
            a1= a1 - b1;

            Console.WriteLine("after Swapping a1=" + a1);
            Console.WriteLine("after Swapping b1=" + b1);

        }
    }
}
