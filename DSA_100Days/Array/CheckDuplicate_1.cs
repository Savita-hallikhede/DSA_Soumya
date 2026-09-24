using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    internal class CheckDuplicate_1
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11 };

            bool duplicate = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        Console.WriteLine("Duplicate is: " + arr[i]);
                        duplicate = true;
                        break;
                    }
                }
            }

            if (!duplicate)
            {
                Console.WriteLine("No duplicate");
            }
        }
    
    }
}
