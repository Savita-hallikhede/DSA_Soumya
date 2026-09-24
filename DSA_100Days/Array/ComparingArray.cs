using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    internal class ComparingArray
    {
      
        public static void Main(string[] args)
        {
            int[] arr1 = { 10, 90, 30, 40 };
            int[] arr2 = { 10, 20, 30, 40 };

            bool isEqual = true;

            if (arr1.Length != arr2.Length)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Both arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }
    }
}

