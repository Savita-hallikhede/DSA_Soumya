using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Reverse an ArrayList
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                2,3,4,5,6,7,8,9
            };

            list.Reverse();

            foreach (int i in list)
            {
                int val = Convert.ToInt32(i);
               
                Console.WriteLine(val);
            }
        }
    }
}
