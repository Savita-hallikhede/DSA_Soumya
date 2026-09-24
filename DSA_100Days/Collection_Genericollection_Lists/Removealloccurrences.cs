using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Removes all occurrences of a particular value

    internal class Removealloccurrences
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                22, 23, 22, 25, 22, 27, 22
            };

            Console.WriteLine("Enter the value that you want to remove");
            int value = Convert.ToInt32(Console.ReadLine());

            while(list.Remove(value)) 
            {

            }

            Console.WriteLine("Remening list:");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }


            
        }
    }
}
