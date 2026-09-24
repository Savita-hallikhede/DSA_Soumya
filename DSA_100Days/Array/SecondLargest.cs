using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find the second-largest element in an array.
    internal class SecondLargest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array");
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = 0;
            int SecondLargest = 0;

            for(int i=0; i<n; i++)
            {
                if(arr[i] > largest)
                {
                    SecondLargest = largest;
                    largest = arr[i];
                    
                }
            }
            Console.WriteLine("largest:" +largest);
            Console.WriteLine("Second Largest:"+SecondLargest);
        }
    }
}
