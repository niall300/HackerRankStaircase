using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Consider a staircase of size :

//   #
//  ##
// ###
//####
//Observe that its base and height are both equal to n,
//    and the image is drawn using # symbols and spaces. 
//    The last line is not preceded by any spaces.

//Write a program that prints a staircase of size.
namespace HackerRankStaircase
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BuildStaircase(n);
            Console.ReadLine();
        }

        static void BuildStaircase(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            //for (int i = 0; i < n; i++)
            //{

            //    while (i < (n - 1))
            //    {
            //        Console.Write(" ");
            //        n--;
            //    }

            //    Console.WriteLine("#");


            //}




        }
    }
}
