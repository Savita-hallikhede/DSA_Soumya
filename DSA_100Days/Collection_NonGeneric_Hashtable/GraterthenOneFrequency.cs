using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find all elements having frequency greater than 1
    internal class GraterthenOneFrequency
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,3,4,5,5,6,6
            };

            Hashtable ht = new Hashtable();

            foreach (int i in list)
            {
                if (ht.ContainsKey(i))
                {
                    ht[i] = (int)ht[i] + 1;
                }
                else
                {
                    ht.Add(i, 1);
                }
            }

            foreach (DictionaryEntry item in ht)
            {
                if ((int)item.Value > 1)
                {
                    Console.WriteLine("The elements with grquency 1 are : " + item.Key);
                }
            }

        }
       
    }
}
