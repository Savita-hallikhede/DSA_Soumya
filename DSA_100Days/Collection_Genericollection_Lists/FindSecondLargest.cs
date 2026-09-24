using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find second largest
    internal class FindSecondLargest
    {
        public void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22,42,53,66,54,76,98
            };

            int largest = 0;
            int secondLargest = 0;

            for(int i=0; i<list.Count; i++)
            {
                if(list[i] > largest)
                {
                    secondLargest = largest;
                    largest = list[i];
                }
            }

            Console.WriteLine("Largest element:"+ largest);
            Console.WriteLine("second largest element:" + secondLargest);
        }
    }
}
