using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DSA_100Days.Day_10.ArrayList_basic
{
    //Remove duplicate elements
    internal class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,33,33,4,5,66,6
            };

            ArrayList unique = new ArrayList();
            for (int i =0; i< list.Count; i++)
            {
                if(!unique.Contains(list[i]))
                {
                    unique.Add(list[i]);
                }
            }

            Console.WriteLine("after removing duplicates:");
            foreach (int i in unique)
            {
                Console.WriteLine(i);
            }
        }
    }
}
