using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaggedArray
{
    public class Program
    {
        static void Main()
        {
            const int rows = 4;

            int[][] jaggedArray = new int[rows][];

            jaggedArray[0] = new int[5];

            jaggedArray[1] = new int[2];

            jaggedArray[2] = new int[3];

            jaggedArray[3] = new int[5];

            jaggedArray[0][3] = 15;
            jaggedArray[1][1] = 12;
            jaggedArray[2][1] = 9;
            jaggedArray[2][2] = 99;
            jaggedArray[3][0] = 10;
            jaggedArray[3][1] = 11;
            jaggedArray[3][2] = 12;
            jaggedArray[3][3] = 13;
            jaggedArray[3][4] = 14;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("jaggedArray[0][{0}]={1}",
                i,jaggedArray[0][i]);
            }

            for (int i = 0; i < 2; i++)
			{
                Console.WriteLine("jaggedArray[1][{0}]={1}",
                    i,jaggedArray[1][i]);
			}

            for (int i = 0; i < 3; i++)
			{
                Console.WriteLine("jaggedArray[2][{0}]={1}",
                    i,jaggedArray[2][i]);
			}

            for (int i = 0; i < 5; i++)
			{
                Console.WriteLine("jaggedArray[3][{0}]={1}",
                    i,jaggedArray[3][i]);
			}

            Console.ReadLine();
        }
    }
}
