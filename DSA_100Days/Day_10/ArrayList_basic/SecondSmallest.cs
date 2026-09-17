using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic
{
    //Find second smallest element
    internal class SecondSmallest
    {
        public static void Main(string[] args)
        {
              
        
            ArrayList list = new ArrayList()
            {
                22,43,52,66,87,9,21,92
            };

            int smallest = Convert.ToInt32(list[0]);
            int secondSmallest = Convert.ToInt32(list[0]);

            for (int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);
                if (value < smallest)
                {
                    secondSmallest = smallest;
                    smallest = value;
                }
            }

            Console.WriteLine("smallest value:" + smallest);
            Console.WriteLine("Second smallest value:" + secondSmallest);
        }
    }
}
    

