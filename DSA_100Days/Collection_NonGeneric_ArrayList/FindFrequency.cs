using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find the frequency of every element
    internal class FindFrequency
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1, 2,2,3, 3, 4,0,9,8,7,6
            };

            for(int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for(int j = 0; j<list.Count; j++)
                {
                    int value1 = Convert.ToInt32(list[i]);
                    int value2 = Convert.ToInt32(list[j]);  

                    if(value1 == value2)
                    {
                        count++;
                    };
                }

                bool isCounted = false;
                for(int k=0; k < i; k++)
                {
                    int kvalues = Convert.ToInt32(list[k]);
                    int ivalues = Convert.ToInt32(list[i]);

                    if (kvalues == ivalues)
                    {
                        isCounted = true;
                        break;
                    };

                    
                }
                if (!isCounted)
                {
                    Console.WriteLine($"the frequency of the {list[i]} is {count}");

                };
            }
        }
    }
}
