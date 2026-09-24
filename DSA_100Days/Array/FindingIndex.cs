using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Find the index of a given element
    internal class FindingIndex
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter the array:");
            
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the element that you want to find their index:");
            int element = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<arr.Length;i++)
            {
                if (arr[i] == element)
                {
                    Console.WriteLine($"The index of the element {arr[i]} is : {i}");
                }
            }

        }
    }
}
