using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Remove duplicate elements
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Enter the size of the element:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Arraylist elements:");
            for(int i=0; i<n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

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

           
            foreach(DictionaryEntry item in ht)
            {
                if((int)item.Value > 1)
                {

                    continue;
                  
                }
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
