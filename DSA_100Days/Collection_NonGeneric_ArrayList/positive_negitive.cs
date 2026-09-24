using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Count positive and negative elements
    internal class positive_negitive
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                2,-1,5,-0,6,-5,-9,7,8
            };

            int PositiveCont = 0;
            int NegativeCont = 0;

            for(int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);
                if(value> PositiveCont)
                {
                    PositiveCont++;
                }else if(value< NegativeCont)
                {
                    NegativeCont++;
                }
            }
            Console.WriteLine("Positive numbers are:" + PositiveCont);
            Console.WriteLine("Negetive numbers are:" + NegativeCont);


        }
    }
}
