using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{

    internal class Insert
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Enter size of the element:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements:");
            for(int i=0; i<n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                list.Add(value);
            }

            Console.WriteLine("Enter the element to insert:");
            int newValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the index:");
            int index = Convert.ToInt32(Console.ReadLine());

            list.Insert(index, newValue);

            Console.WriteLine("updated list:");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
