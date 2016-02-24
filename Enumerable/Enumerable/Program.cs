using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerable
{
    public class ListBoxTest:IEnumerable<string>
    {
        private string[] strings;
        private int ctr = 0;

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string s in strings)
            {
                yield return s;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ListBoxTest(params string[] initialStrings)
        {
            strings = new String[8];

            foreach(string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }

        public void Add(string theString)
        {
            strings[ctr] = theString;
            ctr++;
        }

        public string this[int index]
        {
            get
            {
                if(index<0 || index>= strings.Length)
                {

                }
                return strings[index];
            }
            set
            {
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

            foreach (string s in lbt)
            {
                Console.WriteLine("Value: {0}", s);
            }

            Console.ReadLine();
        }
    }
}
