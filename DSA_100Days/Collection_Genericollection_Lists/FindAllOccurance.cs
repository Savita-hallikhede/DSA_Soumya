using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Find all occurrences
    internal class FindAllOccurance
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,
                2,
                3,
                22,
                5,
               22,
                7,
               22,
                9,
                22
            };

            Console.WriteLine("Enter the element that you want to know their occurance:");
            int value = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<list.Count; i++)
            {
                if (list[i] == value)
                {
                    Console.WriteLine($"The value {value} occured at {i}");
                }
            }

        }
    }
}
