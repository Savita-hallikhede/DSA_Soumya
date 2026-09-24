using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Search for an element in an array.
    internal class SearchingElement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the element odf the array:");
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the elemnt to search the array:");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for(int i=0; i<n; i++)
            {
                if(arr[i] == search)
                    found = true;
                   
            }

            if(found)
            {
                Console.WriteLine("The Element is present in the array");
            }
            else
            {
                Console.WriteLine("The Element is not present in the array");
            }

        }
    }
}
