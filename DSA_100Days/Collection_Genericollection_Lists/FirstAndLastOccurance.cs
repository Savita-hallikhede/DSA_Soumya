using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    // first occurrence and last occurrence
    internal class FirstAndLastOccurance
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22,
                54,
                34,
                76,
                54,
                54,
                64
            };

            
            Console.WriteLine("Enter the element to know their occurane:");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(list.IndexOf(value));
            Console.WriteLine(list.LastIndexOf(value));
        }
    }
}
