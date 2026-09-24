using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to find the first non-repeated character.
    internal class Non_Repeated_Charachters
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();

            for(int i=0; i<str.Length; i++)
            {
                bool repeated = false;
                for(int j=0; j<i; j++)
                {
                    if(str[i] == str[j])
                    {
                        repeated = true;
                    }
                }
                if(!repeated)
                {
                    Console.Write(str[i]);
                }
            }
        }
    }
}
