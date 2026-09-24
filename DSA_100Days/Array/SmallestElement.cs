using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find the smallest element in an array.
    internal class SmallestElement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of element:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = arr[0];
            for(int i=0; i<n; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            Console.WriteLine("smallest array is:"+smallest);
        }
    }
}
