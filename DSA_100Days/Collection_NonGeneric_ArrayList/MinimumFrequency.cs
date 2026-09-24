using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find the element with minimum frequency
    internal class MinimumFrequency
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,1,2,2,3,3,4,4,4,4,4,5
            };

            int minFrequency = 9;
            int minElement = 0;

            for(int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for(int j = 0; j < list.Count; j++)
                {
                    if (Convert.ToInt32(list[i]) == Convert.ToInt32(list[j]))
                    {
                        count++;
                    }
                }

                if(count< minFrequency)
                {
                    minFrequency = count;
                    minElement = Convert.ToInt32(list[i]);
                }
            }

            Console.WriteLine("Minimum frequency:" + minFrequency);
            Console.WriteLine("Minimun Element :" + minElement);
        }
    }
}
