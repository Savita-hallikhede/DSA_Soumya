using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList

{
    //Find duplicate elements
    internal class FindDuplicates
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,4,3,5,6
            };

            
            for(int i = 0; i < list.Count; i++)
            {
                int count = 0;
                int value = Convert.ToInt32(list[i]);
                for(int j=0; j<i; j++)
                {

                    if (Convert.ToInt32(list[j]) == value)
                    {
                        count++;
                        break;
                    }
                }
                if (count>0)
                {
                    Console.WriteLine("duplicate element is" + value);
                }
            }
        }
    }
}
