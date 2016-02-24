using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForEach
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

    public class Tester
    {
        static void Main()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            foreach(int i in intArray)
            {
                Console.WriteLine(i.ToString());
            }

            foreach(Employee e in empArray)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
