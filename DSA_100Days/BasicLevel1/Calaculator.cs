using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day1
{
    //Write a program to perform addition, subtraction, multiplication, and division.

    internal class Calaculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("Division");

            Console.WriteLine("Choose in between(1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                Console.WriteLine(num1 + num2);
                break;

                case 2:
                Console.WriteLine(num1 - num2);
                break;

                case 3:
                Console.WriteLine(num1 * num2);
                break;

                case 4:
                    if(num2 ==0)
                    {
                        Console.WriteLine("Enter the valid number");
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }
                 break;

                default:
                    Console.WriteLine("Invalid function");
                    break;

            }
        }
    }
}
