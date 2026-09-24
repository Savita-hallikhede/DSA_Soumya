using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to convert Celsius to Fahrenheit.

    internal class C_to_F
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temparature in celsius:");
            float cel = float.Parse(Console.ReadLine());

            double farenheit = (cel * 9 / 5) + 32;
            Console.WriteLine("Fahernit : "+ farenheit);



        }
    }
}