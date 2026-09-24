using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Maximum and minimum difference
    internal class MaxMin
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                23, 26,87,64,20
            };

            int max = Convert.ToInt32(list[0]);
            int min = Convert.ToInt32(list[0]);

            for(int i = 0; i<list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);

                if (value > max)
                {
                    max= value;
                }else if(value < min)
                {
                    min = value;
                }
                    

                
            }
            Console.WriteLine("Maximum element:"+max);
            Console.WriteLine("Minimum element:" + min);
        }
    }
}
