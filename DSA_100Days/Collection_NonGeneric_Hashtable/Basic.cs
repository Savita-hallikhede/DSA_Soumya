using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    internal class Basic
    {
        public static void Main(string[] args)
        {
            // 1. Create Hashtable
            Hashtable student = new Hashtable();

            // 2. Add key-value pairs
            student.Add( "soumya",101);
            student.Add( "adi" , 102);
            student.Add( "shekhar", 103);
            student.Add( "harsh", 104);
            student.Add( "vedu", 105);

            // 3. Print all key-value pairs
            Console.WriteLine("All key-value pairs:");
            foreach(DictionaryEntry item in student)
            {
                Console.WriteLine(item.Key +" : " + item.Value);
            }

            // 4. Find marks using student name
            Console.WriteLine("Savita's Marks:" + student["adi"]);

            // 5. Access a value using a key
            Console.WriteLine(student["shekhar"]);

            // 6. Number of elements
            Console.WriteLine("All elements:" +student.Count);

            // 7. Check whether a key exists
            Console.WriteLine(student.ContainsValue(104));

            // 8. Check whether a value exists
            Console.WriteLine(student.ContainsValue("harsh"));

            // 9. Update a value
            student["soumya"] = 95;
            Console.WriteLine("\nUpdated Savita's marks: " + student["soumya"]);

            // 10. Remove a key-value pair
            student.Remove("vedu");

            Console.WriteLine("Removed vedu");
            foreach(DictionaryEntry item in student)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            // 11. Print all keys
            Console.WriteLine("\nAll keys:");
            foreach (var key in student.Keys)
            {
                Console.WriteLine(key);
            }

            // 12. Print all values
            Console.WriteLine("\nAll values:");
            foreach (var value in student.Values)
            {
                Console.WriteLine(value);
            }

            // 13. Check whether Hashtable is empty
            if (student.Count == 0)
            {
                Console.WriteLine("\nHashtable is empty");
            }
            else
            {
                Console.WriteLine("\nHashtable is not empty");
            }

            // 14. Remove all elements
            student.Clear();

            // 15. Check again whether Hashtable is empty
            if (student.Count == 0)
            {
                Console.WriteLine("After Clear(): Hashtable is empty");
            }

        }
    }
}
