using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIndexer
{
    public class ListBoxTest
    {
        private string[] strings;
        private int ctr = 0;

        public ListBoxTest(params string[] initialStrings)
        {
            strings = new String[256];

            foreach(string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }

        public void Add(string theString)
        {
            if (ctr >= strings.Length)
            {
                // handle bad index
            }
            else
                strings[ctr++] = theString;
        }

        public string this[int index]
        {
            get
            {
                if(index<0 || index>=strings.Length)
                {
                    //handle bad index
                }
                return strings[index];
            }
            set
            {
                if (index > ctr)
                {
                    //handle error
                }
                else
                    strings[index] = value;
            }
        }

        public int GetNumEntries()
        {
            return ctr;
        }
    }

    public class Program
    {
        static void Main()
        {
            ListBoxTest lbt =
                new ListBoxTest("Hello", "World");

            lbt.Add("Who");
            lbt.Add("Is");
            lbt.Add("Douglas");
            lbt.Add("Adams");

            string subst = "Universe";
            lbt[1] = subst;

            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine("lbt[{0}]: {1}", i, lbt[i]);
            }

            Console.ReadLine();
        }
    }
}
