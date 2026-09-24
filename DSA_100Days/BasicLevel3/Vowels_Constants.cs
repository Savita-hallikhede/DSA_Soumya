using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to count vowels and consonants.
    internal class Vowels_Constants
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            int vowels = 0;
            int constants = 0;

            for(int i=0; i<str.Length; i++)
            {
                if(str[i] =='a' || str[i] == 'e' || str[i] == 'i'|| str[i] == 'o' || str[i] == 'u')
                {
                    vowels++;
                }
                else if(str[i] > 'a' && str[i] < 'z'  ) 
                {
                    constants++;
                }
                       
            }

            Console.WriteLine("number of vowels are:" +vowels);
            Console.WriteLine("number of consonats are" +constants);
        }
    }
}
