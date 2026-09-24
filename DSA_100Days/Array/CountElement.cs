using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Count the number of elements in an array
    internal class CountElement
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 ,22};
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }

}
