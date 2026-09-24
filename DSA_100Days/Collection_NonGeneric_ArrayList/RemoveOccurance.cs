using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Remove given occurrences of a given element

    internal class RemoveOccurance
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Enter the element that u want to delete:");
            int element = Convert.ToInt32(Console.ReadLine());

            list.Remove(element);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
