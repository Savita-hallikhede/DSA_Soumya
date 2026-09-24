using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Reverse an array.
    internal class ReverseArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            for(int i= arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
