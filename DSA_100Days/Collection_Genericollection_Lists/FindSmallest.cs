using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find smallest
    internal class FindSmallest
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                54,66,93,26,54
            };

            int smallest = 99;

            for(int i=0; i< list.Count;i++)
            {
                if(list[i] < smallest)
                {
                    smallest = list[i];
                }
            }

            Console.WriteLine("The smallest number is:" + smallest);
        }
    }
}
