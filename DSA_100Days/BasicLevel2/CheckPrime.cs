using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to check whether a number is prime.
    internal class CheckPrime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter th number:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if(num<=1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if(num%i==0)
                    {
                        isPrime=false;
                    }

                }
            }
                

            if(isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
            
        }
    }
}
