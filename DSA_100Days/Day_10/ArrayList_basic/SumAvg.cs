using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic
{
    //Find the sum of all elements and Average

    internal class SumAvg
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
               99,65,78,97
            };
            int sum = 0;
            foreach(int i in list)
            {
                sum = sum + i;
            }

            double avg = (double)sum / list.Count;

            Console.WriteLine("sum is:"+sum);
            Console.WriteLine("average is:" + avg);
        }
    }
}
