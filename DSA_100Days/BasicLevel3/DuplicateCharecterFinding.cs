using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to find duplicate characters.
    internal class DuplicateCharecterFinding
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            
            for(int i=0; i<str.Length; i++) 
            {
                int count = 0;

                for (int j=0; j<str.Length; j++)
                {
                     if(str[i] == str[j])
                     {
                        count++;
                     }  
                }

                bool alreadyCounted = false;
                for(int k=0; k<i; k++)
                {
                    if (str[i] == str[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (!alreadyCounted && count > 1)
                {
                    Console.WriteLine($"Duplicate charachter is : {str[i]} and its frequency is: {count}");
                }

            }

        }
    }
}