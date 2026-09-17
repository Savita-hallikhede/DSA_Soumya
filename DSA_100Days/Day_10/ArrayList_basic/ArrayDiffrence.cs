using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic
{
    internal class ArrayDiffrence
    {
        public static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList()
            {
                1,2,3,4,5,6,7,8,9
            };

            ArrayList list2 = new ArrayList()
            {
                7,8,9,10,11
            };

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list2.Contains(list1[i]))
                {
                    Console.WriteLine(list1[i]);
                }
            }
        }
    }
}
