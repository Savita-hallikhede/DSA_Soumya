using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    internal class Remove
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                11,21,31,41,51,61
            };

            list.Remove(2);//index -> not applicable
            list.Remove(11);//value,Remove() always treats the number you give as the value, not the index.


            //if you want to remove by index the use:
            list.RemoveAt(2);


            Console.WriteLine("updated list:");
           
            foreach(int i in list)
            {
               Console.WriteLine(i);
            }

            

           

        }
    }
}
