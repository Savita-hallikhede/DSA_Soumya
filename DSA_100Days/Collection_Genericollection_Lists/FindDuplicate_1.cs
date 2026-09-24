using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //find duplicate
    internal class FindDuplicate_1
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 3, 4, 5, 6, 7, 8 };

            for(int i=0; i<list.Count; i++)
            {
                for(int j=0; j<i; j++)
                {
                    if(list[i].Equals(list[j]))
                    {
                        Console.WriteLine("duplicate element is:"+list[i]);
                        break;
                    }
                }
            }
        }
    }
}
