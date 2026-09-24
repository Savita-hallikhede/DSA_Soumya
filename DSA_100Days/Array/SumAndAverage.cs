using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find the sum and average of array elements.
    internal class SumAndAverage
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum = sum+arr[i];
            }

            double avg = (double)sum + arr.Length;

            Console.WriteLine("sum : "+ sum);
            Console.WriteLine("avg : " + avg);
        }
    }
}
