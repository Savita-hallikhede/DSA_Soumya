using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //without size take input from the user

    internal class WithoutSizeTakeInput
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            string choice;

            do
            {
                Console.WriteLine("Enter the element:");
                int value = Convert.ToInt32(Console.ReadLine());

                list.Add(value);

                Console.WriteLine("Do you want to add another element?(yes/no):");
                choice = Console.ReadLine();

            } while (choice == "yes");

            Console.WriteLine("List of the elements:");

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

          
        }
    }
}
