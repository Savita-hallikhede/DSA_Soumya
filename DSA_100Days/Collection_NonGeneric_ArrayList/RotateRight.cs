using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Rotate an ArrayList right by one position
    internal class RotateRight
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
               1, 2, 3, 4, 5
            };   

            object last = list[list.Count - 1];

            for (int i = list.Count - 1; i > 0; i--)
            {
                list[i] = list[i - 1];
            }

            list[0] = last;

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
