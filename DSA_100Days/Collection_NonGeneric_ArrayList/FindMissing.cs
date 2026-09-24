using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find the missing number
    internal class FindMissing
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,3,5,6
            };

            int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);
                sum  = sum + value;
            }

            int largest = 0;
            for(int i = 0;i < list.Count; i++)
            {
                int value= Convert.ToInt32(list[i]);
                if(value > largest)
                {
                    largest = value;
                }
            }

            double actualValue = sum;
            double expectedValue = (double)largest * (largest + 1) / 2;

            double MissingValue = expectedValue - actualValue;

            Console.WriteLine("Missing value is" + MissingValue);


        }
    }
}
