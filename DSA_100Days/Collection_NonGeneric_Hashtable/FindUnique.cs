using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find unique elements
    internal class FindUnique
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,1,2,1,2,3
            };

            Hashtable ht = new Hashtable();

            foreach(int i in list)
            {
                if(ht.ContainsKey(i))
                {
                    ht[i] = (int)ht[i]+1;
                }
                else
                {
                    ht.Add(i,1);
                }   
                
            }

            bool is_unique = false;
            foreach(DictionaryEntry item in ht)
            {
                if((int)item.Value  == 1)
                {
                    is_unique = true;
                    Console.WriteLine("Duplicate key and valu is " + item.Key + " " + item.Value);
                }
            }

            if(!is_unique)
            {
                Console.WriteLine("no unique elements present in hashtable");
            }
        }
    }
}
