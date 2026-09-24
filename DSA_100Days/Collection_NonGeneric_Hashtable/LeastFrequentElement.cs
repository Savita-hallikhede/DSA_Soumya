using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find the least frequent element
    internal class LeastFrequentElement
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
              66,65,65,44,44,44,44,66,8
            };

            Hashtable ht = new Hashtable();

            foreach (int i in list)
            {
                if(ht.ContainsKey(i))
                {
                    ht[i] = (int)ht[i] + 1;
                }
                else
                {
                    ht.Add(i, 1);
                }
            }

            int leastFrequency = int.MaxValue;
            int LeastFrequentElement = 0;

            foreach (DictionaryEntry item in ht)
            {
                if((int)item.Value < leastFrequency)
                {
                    leastFrequency = (int)item.Value;
                    LeastFrequentElement = (int)item.Key;

                }
            }

            Console.WriteLine($"Least frequent element is {LeastFrequentElement}  its frequency is {leastFrequency}");
        }
    }
}

