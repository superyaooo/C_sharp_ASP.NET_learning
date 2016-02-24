using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingGoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
        repeat: // the label
            Console.WriteLine("i: {0}", i);
        i++;
        if (i < 10)
            goto repeat; // the dastardly deed
        Console.ReadLine();
        return;
        }
    }
}
