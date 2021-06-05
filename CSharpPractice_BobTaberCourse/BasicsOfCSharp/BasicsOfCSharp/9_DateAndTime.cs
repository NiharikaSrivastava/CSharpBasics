/*using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateObj = DateTime.Now;
            Console.WriteLine("Today's Date (default format): "+dateObj.ToString());
            Console.WriteLine("Today's Date (short): " + dateObj.ToShortDateString());
            Console.WriteLine("Today's Time (short): " + dateObj.ToShortTimeString());
            Console.WriteLine("Today's Date (long): " + dateObj.ToLongDateString());
            Console.WriteLine("Today's Time (long): " + dateObj.ToLongTimeString());

            //Math on Dates and Times including chaining
            Console.WriteLine("Adding days, months: "+dateObj.AddDays(3).AddMonths(2).ToLongDateString());
            Console.WriteLine("Previous days, months: " + dateObj.AddDays(-5).AddMonths(-1).ToLongDateString()); //negative value to subtract date
            Console.WriteLine("Date: " +dateObj.Day + "/" + dateObj.Month + "/" + dateObj.Year + " " + dateObj.DayOfWeek); //my own desired format

            DateTime myBDay = DateTime.Parse("14/2/2000");
            Console.WriteLine("My BirthDate: "+myBDay.ToLongDateString());
            TimeSpan myAge = DateTime.Now.Subtract(myBDay); //Subtracting bdate from current date
            Console.WriteLine("Total days for which I have been alive for: " + myAge.TotalDays);

        }
    }
}
*/