using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to convert Fahrenheit to Celsius.
    internal class F_to_C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temparature in farenheit:");
            float fa = float.Parse(Console.ReadLine());

            double cel = (fa - 32) + 5 / 9;

            Console.WriteLine(cel);

        }
    }
}
