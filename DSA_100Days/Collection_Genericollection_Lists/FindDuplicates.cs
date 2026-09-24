using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find duplicates
    internal class FindDuplicates
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22,22,22,6,3,2,3,4,2,6,
            };

            
            for(int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for (int j = 0; j< list.Count; j++)
                {
                    if(list[i] == list[j])
                    {
                        count++;
                    }
                }

                bool alreadyCounted  = false;
                for(int k=0; k< i; k++)
                {
                    if (list[k] == list[i])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if(!alreadyCounted)
                {
                    Console.WriteLine($"The number {list[i]} printed {count} times");
                }
                
            }
        }
    }
}
