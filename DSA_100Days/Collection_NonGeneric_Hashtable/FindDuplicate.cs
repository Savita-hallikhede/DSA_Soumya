using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find duplicate elements
    internal class FindDuplicate
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                11,2,33,44,22,2,43,
            };

            Hashtable ht = new Hashtable();

            for(int i=0; i< list.Count; i++)
            {
                if(ht.ContainsKey(list[i]))
                {
                    ht[list[i]] = (int)ht[list[i]] + 1;
                }else
                {
                    ht.Add(list[i], 1);
                }

            }
            bool isDuplicate = true;
            foreach(DictionaryEntry item in ht)
            {
                if((int)item.Value > 1)
                {
                    isDuplicate = true;
                    Console.WriteLine("Duplicate element is " + item.Key + " is is appeard "+ item.Value + "times");
                }
            }

            if(!isDuplicate)
            {
                Console.WriteLine("No duplicate value");
            }
        }
    }
}
