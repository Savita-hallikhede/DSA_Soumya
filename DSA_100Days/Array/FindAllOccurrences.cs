using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find all occurrences of a given element
    internal class FindAllOccurrences
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 5, 2, 7, 8 };

            Console.WriteLine("Enter the element that you want to search");
            int element = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] == element)
                {
                    Console.WriteLine($"{arr[i]} is a the index {i}");
                }
             
            }

        }
    }
}
