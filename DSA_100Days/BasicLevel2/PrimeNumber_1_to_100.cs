using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to print all prime numbers between 1 and 100.
    internal class PrimeNumber_1_to_100
    {
        public static void Main(string[] args)
        {
          
           
           for(int i=2; i<100; i++)
           {
                bool isPrime = true;

                for (int j=2; j<i; j++)
               {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
               }
                if (isPrime)
                {
                    Console.WriteLine(i);

                }
            }

           
        }
    }
}
