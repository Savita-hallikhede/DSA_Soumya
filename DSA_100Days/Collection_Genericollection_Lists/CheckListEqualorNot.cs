using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Compare two Lists
    internal class CheckListEqualorNot
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };

            if(list.SequenceEqual(list1))
            {
                Console.WriteLine("Two list are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
