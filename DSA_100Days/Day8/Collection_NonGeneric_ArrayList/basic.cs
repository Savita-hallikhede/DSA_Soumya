using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_100Days.Day8.Collection_NonGeneric_ArrayList
{
    internal class basic
    {
        public static void Main(string[] args)
        {
            //1.create and print all elements
            ArrayList arrayList = new ArrayList() { 1, 2,3,4,5, "soumya", 33.4 };


            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            //2. Add an element
            arrayList.Add('s');

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Total number present in arrayList:"+arrayList.Count);


            // 4.Find the first element
            Console.WriteLine("First element:" + arrayList[0]);


            //5.Find the last element
            Console.WriteLine("Lasst element:" +arrayList[arrayList.Count-1]);

            //6.Access an element using its index
            Console.WriteLine("Enter the index for accessing the element:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"at index {index} the element present is:"+arrayList[index]);

            // 7.Check whether an element exists
            Console.WriteLine("Enter the element that you want to check whether it is exist or not:");
            int search = Convert.ToInt32(Console.ReadLine());

            if(arrayList.Contains(search))
            {
                Console.WriteLine("Element is exist");
            }
            else
            {
                Console.WriteLine("Element is not exist");
            }

            //8.Find the index of a given element

            Console.WriteLine("Enter the element to theier  index:");
            int element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The element {element} index is {arrayList.IndexOf(element)} ");

            //9.Remove a given element
            Console.WriteLine("Enter the element to remove:");
            int remove = Convert.ToInt32(Console.ReadLine());

            arrayList.Remove(remove);

            //Remove() does NOT return the removed element Remove() returns a boolean:

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            //10. Remove an element from a given index
            Console.WriteLine("Enter the index that element you want to remove:");
            int indextoremove = Convert.ToInt32(Console.ReadLine());

            arrayList.RemoveAt(indextoremove);

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

        }





    }
}
