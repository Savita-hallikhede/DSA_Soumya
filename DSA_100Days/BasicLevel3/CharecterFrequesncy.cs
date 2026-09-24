using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to count the frequency of each character.
    internal class CharecterFrequesncy
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            
            for(int i=0; i<name.Length; i++)
            {
                int count = 0;
                for (int j=0; j<name.Length; j++)
                {
                    if(name[j] == name[i])
                    {
                        count++;
                    }
                }

                bool alreadyCounted = false;
                for(int k=0; k<i; k++)
                {
                    if(name[i] == name[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                        
                }

                if(!alreadyCounted)
                {
                    Console.WriteLine($"The frequency the {name[i]} is {count}");
                }
            }



        }
    }
}
