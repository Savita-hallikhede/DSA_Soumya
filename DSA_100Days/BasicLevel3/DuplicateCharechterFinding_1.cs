using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to find duplicate characters.
    internal class DuplicateCharechterFinding_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            
            for(int i=0; i<str.Length; i++)
            {
                bool duplicate = false;
                for(int j=0; j<i; j++)
                {
                    if(str[i] == str[j])
                    {
                        duplicate = true;
                    }
                }

                if(duplicate)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}
