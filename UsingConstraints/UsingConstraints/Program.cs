using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingConstraints
{
    public class Employee:IComparable<Employee>
    {
        private string name;
        public Employee(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }

        public int CompareTo(Employee rhs)
        {
            return this.name.CompareTo(rhs.name);
        }

        public bool Equals(Employee rhs)
        {
            return this.name == rhs.name;
        }
    }

    public class Node<T>:
        IComparable<Node<T>> where T:IComparable<T>
    {
        private T data;
        private Node<T> next = null;
        private Node<T> prev = null;

        public Node(T data)
        {
            this.data = data;
        }

        public T Data { get { return this.data; } }

        public Node<T> Next
        {
            get { return this.next; }
        }

        public int CompareTo(Node<T> rhs)
        {
            return data.CompareTo(rhs.data);
        }

        public bool Equals(Node<T> rhs)
        {
            return this.data.Equals(rhs.data);
        }

        public Node<T> Add(Node<T> newNode)
        {
            if(this.CompareTo(newNode)>0)
            {
                newNode.next = this;

                if(this.prev!=null)
                {
                    this.prev.next = newNode;
                    newNode.prev = this.prev;
                }

                this.prev = newNode;
                return newNode;
            }
            else
            {
                if(this.next!=null)
                {
                    this.next.Add(newNode);
                }
                else
                {
                    this.next = newNode;
                    newNode.prev = this;
                }

                return this;
            }
        }

        public override string ToString()
        {
            string output = data.ToString();

            if(next!=null)
            {
                output += "," + next.ToString();
            }
            return output;
        }
    }

    public class LinkedList<T> where T:IComparable<T>
    {
        private Node<T> headNode = null;

        public T this[int index]
        {
            get
            {
                int ctr = 0;
                Node<T> node = headNode;

                while(node!=null && ctr<=index)
                {
                    if(ctr==index)
                    {
                        return node.Data;
                    }
                    else
                    {
                        node = node.Next;
                    }

                    ++ctr;
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public LinkedList()
        {
        }

        public void Add(T data)
        {
            if(headNode==null)
            {
                headNode = new Node<T>(data);
            }
            else
            {
                headNode = headNode.Add(new Node<T>(data));
            }
        }

        public override string ToString()
        {
            if(this.headNode!=null)
            {
                return this.headNode.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Run();

            Console.ReadLine();
        }

        public void Run()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            Random rand = new Random();
            Console.Write("Adding: ");

            for (int i = 0; i < 10; i++)
            {
                int nextInt = rand.Next(10);
                Console.Write("{0}", nextInt);
                myLinkedList.Add(nextInt);
            }

            LinkedList<Employee> employees = new LinkedList<Employee>();
            employees.Add(new Employee("Dog"));
            employees.Add(new Employee("pole")); 
            employees.Add(new Employee("tree"));
            employees.Add(new Employee("kfjakof"));

            Console.WriteLine("\nRetrieving collections...");

            Console.WriteLine("Integers: " + myLinkedList);
            Console.WriteLine("Employees: " + employees);
        }
    }
}
