using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day9
{
    internal class MoveZeroToEnd
    {
        //Given an ArrayList containing numbers and 0s, move every 0 to the end of the ArrayList.
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
             0, 2, 0, 5, 7, 0, 9
            };

            int zeroCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (Convert.ToInt32(list[i]) == 0)
                {
                    zeroCount++;
                }
                else
                {
                    Console.Write(list[i] + " ");
                }
            }

            for (int i = 0; i < zeroCount; i++)
            {
                Console.Write("0 ");
            }
        }
    }
}
