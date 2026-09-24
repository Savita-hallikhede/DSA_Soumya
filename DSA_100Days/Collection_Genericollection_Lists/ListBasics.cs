using DSA_100Days.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    internal class ListBasics
    {
        public static void Main(string[] args)
        {
            //Create a List
            List<int> numbers = new List<int>();

            // Add elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            // Print all elements
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Count elements
            Console.WriteLine(numbers.Count);

            // Access by index
            Console.WriteLine(numbers[1]);

            // Update element
            numbers[1] = 22;

            //search
            if(numbers.Contains(10))
            {
                Console.WriteLine("Element found");
            }


        }



    }
}
