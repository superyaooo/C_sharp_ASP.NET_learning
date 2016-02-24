using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchStatement
{
    class Program
    {
        enum Party
        {
            Democrat,
            ConservativeRepublican,
            Republican,
            Libertarian,
            Liberal,
            Progressive,
        };

        static void Main(string[] args)
        {
            Party myChoice = Party.Democrat;

            switch (myChoice)
            { 
                case Party.Democrat:
                    Console.WriteLine("You voted Democratic.\n");
                    break;
                case Party.ConservativeRepublican: // fall through
                //Console.WriteLine(
                //    "Conservative Republicans are voting Republican\n");
                case Party.Republican:
                    Console.WriteLine("You voted Republican.\n");
                    break;
                case Party.Liberal:
                    Console.WriteLine("Liberal is now Progressive");
                    goto case Party.Progressive;
                case Party.Progressive:
                    Console.WriteLine("You voted Progressive.\n");
                    break;
                case Party.Libertarian:
                    Console.WriteLine("Libertarians are voting Democratic");
                    goto case Party.Democrat;
                default:
                    Console.WriteLine("You did not pick a valid choice.\n");
                    break; 
            }
            Console.WriteLine("Thank you for voting.");
            Console.ReadLine();
        }
    }
}
