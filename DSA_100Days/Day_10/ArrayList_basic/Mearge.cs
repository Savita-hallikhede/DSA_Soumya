using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic
{
    //Combine the elements of two ArrayLists into one ArrayList.
    internal class Mearge
    {
        public static void Main(string[] args)

        {
            ArrayList list1 = new ArrayList()
            {
                10,20,10,20
            };
            ArrayList list2 = new ArrayList()
            {
                30,20,10
            };

            list1.AddRange(list2);


            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
