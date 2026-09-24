using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Problem 1: Store student names and marks
    internal class Problem1
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("Savita", 85);
            table.Add("Rahul", 90);
            table.Add("Priya", 78);

            foreach (DictionaryEntry dictionaryEntry in table)
            {
                Console.WriteLine(dictionaryEntry.Key  + "" +  dictionaryEntry.Value);
            }  
        }

        
    }
}
