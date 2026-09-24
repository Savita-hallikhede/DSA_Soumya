using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Copy one List to another

    internal class CopyList
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> list2 = new List<int>(list1);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
