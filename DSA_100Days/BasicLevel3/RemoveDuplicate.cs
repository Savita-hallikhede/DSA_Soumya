using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to remove duplicate characters.
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string str = Console.ReadLine();

            for(int i=0; i<str.Length; i++)
            {
                int count = 0;
                for(int j=0; j<str.Length; j++)
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

                if (!alreadyCounted && count < 2)
                {
                    Console.Write(str[i]);
                }

            }
            
        }
    }
}
