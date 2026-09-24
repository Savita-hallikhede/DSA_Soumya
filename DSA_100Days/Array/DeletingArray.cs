using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Delete an element by its value
    internal class DeletingArray
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            
            Console.WriteLine("Enter the element that you want to delete");
            int element = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[arr1.Length-1];

            int j = 0;
            for(int i=0; i<arr1.Length; i++)
            {
                if(arr1[i] == element)
                {
                    continue;
                }
              
                    arr2[j] = arr1[i];
                    j++;
                

                    
            }

            for(int i=0; i<arr2.Length; i++)
            {
                Console.Write(arr2[i] +" ");
            }
        }
    }
}
