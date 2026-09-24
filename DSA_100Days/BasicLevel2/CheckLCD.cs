using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the LCD of two numbers.
    //LCD (Lowest Common Divisor) is the lowest number that divides both numbers exactly.
    internal class CheckLCD
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int lcd = 1;
            for(int i=1; i<=num1 && i<=num2; i++)
            {
                if( num1%i == 0 && num2%i==0)
                {
                    lcd = i;
                    break;
                }
            }
            Console.WriteLine("Lowest Common Divisor : "+lcd);   

        }
    }
}
