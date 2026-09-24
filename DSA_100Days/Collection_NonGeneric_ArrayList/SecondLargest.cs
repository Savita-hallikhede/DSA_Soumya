using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Move all zeros to the end
    internal class SecondLargest
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                22,43,52,66,87,9,21,92
            };

            int largest = Convert.ToInt32(list[0]);
            int secondLargest = Convert.ToInt32(list[0]);

            for(int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);
                if (value > largest)
                {
                    secondLargest = largest;
                    largest = value;
                }
            }

            Console.WriteLine("largest value:"+largest);
            Console.WriteLine("Second largest value:" + secondLargest);
        }
    }
}
