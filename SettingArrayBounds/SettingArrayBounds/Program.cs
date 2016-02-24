using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SettingArrayBounds
{
    public class SettingArrayBounds
    {
        public static void CreateArrayWithBounds()
        {
            int[] lengthsArray = new int[2] { 3, 5 };
            int[] boundsArray = new int[2] { 2, 3 };
            Array multiDimentionalArray = Array.CreateInstance(
                typeof(String), lengthsArray, boundsArray);

            Console.WriteLine("Bounds:\tLower\tUpper");
            for (int i = 0; i < multiDimentionalArray.Rank; i++)
                Console.WriteLine("{0}:\t{1}\t{2}", i,
                    multiDimentionalArray.GetLowerBound(i),
                    multiDimentionalArray.GetUpperBound(i));
        }

        static void Main()
        {
            SettingArrayBounds.CreateArrayWithBounds();
            Console.ReadLine();
        }
    }
}
