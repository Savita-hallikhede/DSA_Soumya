using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Count the number of distinct elements
    internal class FindDistinctElement
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,3,4,5,6
            };

            Hashtable hs = new Hashtable();

            foreach(int i in list)
            {
                if(hs.ContainsKey(i))
                {
                    hs[i] = (int)hs[i] + 1;
                }
                else
                {
                    hs.Add(i, 1);
                }
            }

            Console.WriteLine(hs.Count);

        }
    }
}
