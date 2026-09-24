using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Remove duplicate elements from an array.
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for(int i=0; i<arr.Length; i++)
            {
                bool isduplicate = false;
                
                for(int j=0; j<i; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        isduplicate = true;
                        break;
                    }
                }

                if(!isduplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
