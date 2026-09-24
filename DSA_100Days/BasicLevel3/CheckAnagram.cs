using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to check whether two strings are anagrams.
    internal class CheckAnagram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string 1:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the string 2:");
            string str2 = Console.ReadLine();

           
           bool anagram = true;
            if(str1.Length != str2.Length)
            {
                anagram = false;
            }
            else
            {
                
                for (int i = 0; i< str1.Length; i++)
                {
                    int str1Count = 0;
                    int str2Count = 0;

                    for (int j=0; j< str1.Length; j++)
                    {
                        if(str1[i] == str1[j])
                        {
                            str1Count++;
                        }
                        if(str1[i] == str2[j])
                        {
                            str2Count++;
                        }
                    }

                    if(str1Count != str2Count)
                    {
                        anagram = false;
                        break;
                    }
                }
            }
            if (anagram)
            {
                Console.WriteLine(" the given string is angram");
            }
            else
            {
                Console.WriteLine(" the given string is not angram");
            }
        }
    }
}
