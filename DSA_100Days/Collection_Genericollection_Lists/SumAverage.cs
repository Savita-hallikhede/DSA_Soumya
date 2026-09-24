using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find sum and average
    internal class SumAverage
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                20,30,40,50
            };

            int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }

            double avg = (double)sum / list.Count;

            Console.WriteLine("Sum of the numbers is:"+sum);
            Console.WriteLine("Average is:"+avg);
        }
    }
}
