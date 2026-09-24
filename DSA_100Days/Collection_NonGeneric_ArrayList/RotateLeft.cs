using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Rotate an ArrayList left by one position
    internal class RotateLeft
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1, 2, 3, 4, 5
            };

            object first = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] = list[i + 1];
            }

            list[list.Count - 1] = first;

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
