using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find the smallest element
    internal class SmallestElement
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Enter the size of the element:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements :");
            for(int i=0; i < n; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                list.Add(element);

            }

            int smallest = Convert.ToInt32(list[0]);
            for(int i=0;i < n; i++)
            {
                int value = Convert.ToInt32(list[i]);
                if(value < smallest)
                {
                    smallest = value;
                }
            }
            Console.WriteLine("smallest value is:" + smallest);
        }
    }
}
