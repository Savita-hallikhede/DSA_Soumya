using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Finding the largest string
    internal class LargestString
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Enter the size of the arrayList:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the string:");
            for(int i=0; i<n; i++)
            {
                string name = Console.ReadLine();
                list.Add(name);         
            }

            string largest = Convert.ToString(list[0]);

            for(int i=0; i<n; i++)
            {
               string name = Convert.ToString(list[i]);
                if(name.Length > largest.Length)
                {
                    largest= name;
                }
            }
            Console.WriteLine("largest name is:"+largest);
        }

    }
}
