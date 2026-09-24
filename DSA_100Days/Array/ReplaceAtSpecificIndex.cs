using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Replace an element at a specific index
    internal class ReplaceAtSpecificIndex
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 22, 23, 24, 25, 21, 56 };

            Console.WriteLine("Enter the position:");
            int  position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the element:");
            int element = Convert.ToInt32(Console.ReadLine());

           for(int i=0; i<arr1.Length; i++)
           {
                if(i == position)
                {
                    arr1[i] = element;
                }
           }

           for(int  i=0; i<arr1.Length; i++)
           {
                Console.WriteLine(arr1[i]);
           }

        }
    }
}
