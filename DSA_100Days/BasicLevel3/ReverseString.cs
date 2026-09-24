using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to reverse a string.
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            string rev = "";
            for(int i= name.Length-1; i>=0; i--)
            {
                rev = rev + name[i];
            }

            Console.WriteLine("Reverse of your name is:"+rev);
        }
        

        
    }
}
