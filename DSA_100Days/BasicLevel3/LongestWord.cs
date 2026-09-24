using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day3
{
    //Write a program to find the longest word in a sentence.
    internal class LongestWord
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();

            string[] word = sentence.Split(' ');
            string longestWord = "";

            foreach(string sen in word)
            {
                if(sen.Length> longestWord.Length)
                {
                    longestWord = sen;
                }
            }
            Console.WriteLine("longestWord is :"+ longestWord);
        }
    }
}
