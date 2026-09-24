using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to find the area of a circle.
    internal class AreaOfCircle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;

            double Area = pi * r * r;

            Console.WriteLine("Area of circle is:" + Area);


        }
    }
}
