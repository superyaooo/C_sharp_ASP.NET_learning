using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(2).ToShortTimeString());

            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //Console.WriteLine(myValue.Month.ToString());
            //Console.WriteLine(myValue.DayOfWeek.ToString());

            //DateTime myBirthday = new DateTime(1985, 11, 29);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("11/29/1985");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();

        }
    }
}
