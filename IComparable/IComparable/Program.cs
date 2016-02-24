using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable
{
    public class Employee:IComparable<Employee>
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        } 

        public bool Equals(Employee other)
        {
            if(this.empID==other.empID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }
    }

    public class Program
    {
        static void Main()
        {
            List<Employee> empArray=new List<Employee>();
            List<Int32> intArray = new List<Int32>();

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100));

                intArray.Add(r.Next(10));
            }

            for (int i = 0; i < intArray.Count; i++)
            {
                Console.Write("{0} ", intArray[i].ToString());
            }
            Console.WriteLine("\n");

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            empArray.Sort();

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
