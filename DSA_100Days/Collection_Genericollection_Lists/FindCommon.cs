using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find common elements
    internal class FindCommon
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() {5,6,7,8,9,0 };

            var common = list1.Intersect(list2);

            foreach(int i in common)
            {
                Console.WriteLine(i);
            }
        }
    }
}
