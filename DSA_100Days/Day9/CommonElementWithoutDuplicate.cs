using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day9
{
    //Find common elements without duplicates

    internal class CommonElementWithoutDuplicate
    {
        public static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList()
            {
                1, 2, 2, 3, 4, 4, 5
            };

            ArrayList list2 = new ArrayList()
            {
                2, 2, 4, 4, 6, 7
            };

            ArrayList common = new ArrayList();

            for (int i = 0; i < list1.Count; i++)
            {
                if (list2.Contains(list1[i]) && !common.Contains(list1[i]))
                {
                    common.Add(list1[i]);
                }
            }

            Console.WriteLine("Common elements without duplicates:");

            foreach (int i in common)
            {
                Console.WriteLine(i);
            }
        }
    }
}
