using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    // Find common elements between two ArrayLists

    internal class CommonElements
    {
        public static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();

            Console.WriteLine("Enter the size:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Arraylist 1:");
            for(int i = 0; i < n1; i++)
            {
                 list1.Add(Convert.ToInt32(Console.ReadLine()));
            }


            ArrayList list2 = new ArrayList();
            Console.WriteLine("Enter the second list size:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Arraylist 1:");
            for (int i = 0; i < n2; i++)
            {
                list2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for(int i=0; i<n1;  i++)
            {
                if (list2.Contains(list1[i]))
                {
                    Console.WriteLine("common elements are:"+list1[i]);
                }
            }
        }
    }
}
