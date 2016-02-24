using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_virtual_methods
{
        public class Control
        {
            protected int Top { get; set; }
            protected int Left { get; set; }

            public Control(int Top,int Left)
            {
                this.Top = Top;
                this.Left = Left;
            }

            public virtual void DrawWindow()
            {
                Console.WriteLine("Control: drawing Control at {0}, {1}",
                    Top, Left);
            }
        }

        public class ListBox: Control
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
                base.DrawWindow();
                Console.WriteLine("Writing string to the listbox: {0}",
                    listBoxContents);
            }
        }

        public class Button:Control
        {
            public Button(
                int top,
                int left):
                    base(top, left)
            {

            }

            public override void DrawWindow()
            {
                Console.WriteLine("Drawing a button at {0}, {1}\n",
                    Top, Left);
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Control win = new Control(1, 2);
                ListBox lb = new ListBox(3, 4, "Stand alone list box");
                Button b = new Button(5, 6);
                win.DrawWindow();
                lb.DrawWindow();
                b.DrawWindow();

                Control[] winArray = new Control[3];
                winArray[0] = new Control(1, 2);
                winArray[1] = new ListBox(3, 4, "List box in array");
                winArray[2] = new Button(5, 6);

                for (int i = 0; i < 3; i++)
                {
                    winArray[i].DrawWindow();
                }

                Console.ReadLine();
            }

            
        }
}
