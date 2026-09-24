using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find the frequency of a given element
    internal class FrequencyOfGivenElement
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,3,3,4,5,6,6,6,7,7,7,7
            };

            Hashtable ht = new Hashtable();

            Console.WriteLine("Enter the number of the arrayList to fid their frequency:");
            int frequency = Convert.ToInt32(Console.ReadLine());

           for(int i = 0; i < list.Count; i++)
           {
                int num = (int)list[i];
                if(frequency == num)
                {
                    if (ht.ContainsKey(frequency))
                    {
                        ht[frequency] = (int)ht[frequency] + 1;
                    }
                    else
                    {
                        ht.Add(frequency, 1);
                    }
                }
                

                Console.WriteLine($"the frequency of {frequency} is {ht[frequency]}");
                
           }


           

        }
    }
}
