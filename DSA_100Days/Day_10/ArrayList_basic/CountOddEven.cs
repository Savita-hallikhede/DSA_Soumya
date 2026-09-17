using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic

{
    internal class CountOddEven
    {
       public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
            };

            int countOdd = 0;
            int countEven = 0;

            for(int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);
                if (value % 2 == 0)
                {
                   countEven++;
                }else
                {
                    countOdd++;
                }
                 
            }
            Console.WriteLine("Odd numbers are:"+ countOdd);
            Console.WriteLine("Even numbers are:" + countEven);

        }
    }
}
