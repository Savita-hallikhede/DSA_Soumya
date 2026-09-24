using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Counting PrimeNumber Between 1 to 100

    internal class CountPrime_1_100
    {
        public static void Main(string[] args)
        {
            int count = 0;

            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    count++;
                    Console.WriteLine(i);
                    

                }
            }
            Console.WriteLine("Total Number of prime number in between 1 to 100 : " + count);
        }
    }
}
