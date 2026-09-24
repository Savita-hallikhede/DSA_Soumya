using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find the element with maximum frequency

    internal class MaxmimumFrequency
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,3,3,3,3,4,5,6,7
            };

            int maxfrequency = 0;
            int maxelement = 0;

            for(int i=0; i<list.Count;i++)
            {
                int count = 0;
                for(int j=0; j<list.Count;j++)
                {
                    if(Convert.ToInt32(list[i]) == Convert.ToInt32(list[j]))
                    {
                        count++;
                    }
                       
                }

                if(count > maxfrequency)
                {
                    maxfrequency = count;
                    maxelement = Convert.ToInt32(list[i]);
                }

            }

            Console.WriteLine("Element with maximum frequency: " + maxelement);
            Console.WriteLine("Maximum frequency: " + maxfrequency);


        }
    }
}
