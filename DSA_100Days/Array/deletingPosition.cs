using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Delete an element from a specific position
    internal class deletingPosition
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 11, 12, 13, 14, 15, 16, 17 };

            Console.WriteLine("Enter the position to delete that element:");
            int position = Convert.ToInt32(Console.ReadLine());

            int j = 0;
            for(int i=0; i<arr1.Length; i++)
            {
                if (i == position )
                {
                    continue;
                }

                arr1[j] = arr1[i];
                j++;

            } 
                
            for(int i=0; i<arr1.Length ; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}
