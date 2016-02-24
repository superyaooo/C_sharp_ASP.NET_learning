using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_method_and_class
{
    abstract public class Control
    {
        protected int top;
        protected int left;

        protected Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        abstract public void DrawWindow();
    }

    public class ListBox:Control
    {
        private string listBoxContents;

        public ListBox(
            int top,
            int left,
            string contents):
                base(top,left)
            {
                listBoxContents = contents;
            }

        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to the listbox: {0}",
                listBoxContents);
        }
    }

    public class Button:Control
    {
        public Button(
            int top,
            int left):
                base(top,left)
        {
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n",
                top, left);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Control[] winArray = new Control[3];
            winArray[0] = new ListBox(1, 2, "First List Box");
            winArray[1] = new ListBox(3, 4, "Second List Box");
            winArray[2] = new Button(5, 6);

            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }

            Console.ReadLine();

        }
    }
}
