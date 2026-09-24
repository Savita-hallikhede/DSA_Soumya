using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find largest 
    internal class FindLargest
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
           {
               33,75,23,82,75,83,27
           };

            int largest = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] > largest)
                {
                    largest = list[i];
                }
            }

            Console.WriteLine("the largest elment is:"+largest);
        }
    }
}
