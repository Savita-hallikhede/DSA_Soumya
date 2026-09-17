using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day_10.ArrayList_basic

{
    //Find the largest element
    internal class LargestElement
    {
        public static void Main(string[] args)
        {

            ArrayList arraylist = new ArrayList();

            Console.WriteLine("Enter the size:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements:");



            for (int i = 0; i < n; i++)
            {
                var num = Convert.ToInt32(Console.ReadLine());
                arraylist.Add(num);

            }

            int largest = Convert.ToInt32(arraylist[0]);
            for (int j = 0; j < arraylist.Count; j++)
            {

                int value = Convert.ToInt32(arraylist[j]);
                if (value > largest)
                {
                    largest = value;
                }
              

            }
            Console.WriteLine("largest element is:" + largest);
        }
    }
}
