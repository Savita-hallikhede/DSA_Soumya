using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_Genericollection_Lists
{
    //Check whether an element exists
    internal class CheckExistOrNot
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "soumya","nikku","pam","akkutara","yogitara"
            };

            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            for(int i =0; i < list.Count; i++)
            {
                if(list[i] == name)
                {
                    Console.WriteLine("name is exist");
                }
            }
        }


    }
}
