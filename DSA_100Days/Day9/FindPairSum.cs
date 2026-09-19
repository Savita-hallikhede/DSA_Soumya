using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day9
{
    //Find pairs whose sum equals a given number
    internal class FindPairSum
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
              2, 4, 3, 5, 7, 8
            };

            int target = 10;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    int first = Convert.ToInt32(list[i]);
                    int second = Convert.ToInt32(list[j]);

                    if (first + second == target)
                    {
                        Console.WriteLine(first + " + " + second + " = " + target);
                    }
                }
            }
        }
    }
}
