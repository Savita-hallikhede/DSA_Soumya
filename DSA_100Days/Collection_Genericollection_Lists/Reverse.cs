using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Reverse the list
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22,3,4,1,2,3,4,5
            };

            
            list.Reverse();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
