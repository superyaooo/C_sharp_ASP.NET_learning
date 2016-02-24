using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCollection
{
    public class Employee
    {
        public Employee(int empID)
        {
            this.EmpID=empID;
        }
        public override string ToString()
        {
            return EmpID.ToString();
        }
        public int EmpID { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();
            List<int> intList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                empList.Add(new Employee(i + 100));
                intList.Add(i * 5);
            }

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }
            Console.WriteLine("\n");

            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }

            Console.WriteLine("\n");
            Console.WriteLine("empList.Capacity: {0}",
                empList.Capacity);

            Console.ReadLine();
        }
    }
}
