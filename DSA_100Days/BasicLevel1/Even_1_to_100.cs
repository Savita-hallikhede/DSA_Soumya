using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to print all even numbers and odd from 1 to 100.
    internal class Even_1_to_100
    {
        public static void Main(string[] args)
        {
            for(int i=1; i<100; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"Even numbers:{i}");
                }
                else
                {
                    Console.WriteLine($"Odd numbers:{i}");
                }
            }
        }
    }
}
