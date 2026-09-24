using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to generate the Fibonacci series.
    internal class FibonacchiSeries
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine("Enter the number of terms:");
            int n = Convert.ToInt32(Console.ReadLine());
          
            
            for(int i=0; i<=n; i++)
            {
                int c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
           
        }
    }
}
