using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Clear the List
    internal class CleartheList
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22,33,44,5,66,3,6
            };

            list.Clear();

            Console.WriteLine("Successfully cleared the all list");
            foreach(int i in list)
            {
                Console.WriteLine(i);

            }

        }
    }
}
