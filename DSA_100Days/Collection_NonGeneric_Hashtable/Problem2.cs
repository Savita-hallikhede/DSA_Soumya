using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Problem 2: Find marks using student name
    internal class Problem2
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("Savita", 85);
            table.Add("Rahul", 90);

            Console.WriteLine(table["Rahul"]);
        }
    }
}
