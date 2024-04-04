using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prints the current date and time to the console.
            Console.WriteLine("It's currently " + DateTime.Now + ".");
            Console.WriteLine("\r");

            // 2. Asks the user for a number.
            Console.WriteLine("GIMME A NUMBER (1 to 12.)");     // to avoid confusion, placing a ceiling of 12 so the time isn't pushed more than 12 hours forward.
            int datNumberDoe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime aDay = DateTime.Now;
            TimeSpan aHour = new System.TimeSpan(datNumberDoe, 0, 0);
            DateTime aHourAfterAHour = aDay.Add(aHour);
            Console.WriteLine("In " + datNumberDoe + " hours, it will be " + aHourAfterAHour + ".");


            Console.ReadLine();
        }
    }
}
