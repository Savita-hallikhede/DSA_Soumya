using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Copy elements from one array to another
    internal class CopiyingElement
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 6, 2, 4, 7 };
            int[] arr2 = new int[arr1.Length];

            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            for(int i=0; i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i] +" ");
            }
        }
    }
}
