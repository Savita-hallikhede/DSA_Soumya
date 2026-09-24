using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find the missing number in an array.
    internal class MissingNumberFinding
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };

            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            int largest = 0;
            for(int i=0; i<arr.Length ; i++)
            {
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            int ActualSum = sum;
            double ExpectedSum = (double)largest * (largest + 1) / 2;

            double MissingValue = ExpectedSum - ActualSum;

            Console.WriteLine("Missing Value:" +MissingValue);
        }
    }
}
