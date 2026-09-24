using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to check whether a person is eligible to vote.

    internal class EligibleForVote
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>= 18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else
            {
                Console.WriteLine("Not Eligible for vote");
            }
        }
    }
}
