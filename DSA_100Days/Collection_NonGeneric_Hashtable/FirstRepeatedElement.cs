using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find the first repeated element
    internal class FirstRepeatedElement
    {
        public static void main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,3,4
            };
            Hashtable ht = new Hashtable();

            foreach(int i in list)
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

            foreach(int i in list)
            {
                if ((int)ht[i] > 1)
                {
                    Console.WriteLine(i);
                    break;
                }
                
               
            }
               

        }
    }
}
