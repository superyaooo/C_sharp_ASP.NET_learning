using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertingArrays
{
    public class Employee
    {
        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        }

        private int empID;
    }

    public class Program
    {
        public static void PrintArray(object[] theArray)
        {
            Console.WriteLine("Contents of the Array{0}",
                theArray.ToString());

            foreach(object obj in theArray)
            {
                Console.WriteLine("Value: {0}", obj);
            }
        }

        static void Main(string[] args)
        {
            Employee[] myEmployeeArray = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                myEmployeeArray[i] = new Employee(i + 5);
            }

            PrintArray(myEmployeeArray);

            String[] array = { "hello", "world" };

            PrintArray(array);

            Console.ReadLine();
        }
    }
}
