using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekdays weekdays = new Weekdays();

            try
            {
// 2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Enter the current weekday.");
// 3. Assign the value to a variable of that enum data type you just created.
                string userinput = Console.ReadLine();
                Weekdays.Days Day = (Weekdays.Days)Enum.Parse(typeof(Weekdays.Days), userinput);
                Console.WriteLine("You picked the day of the week: " + Day);
            }
// 4. Wrap the above statement in a try/catch block and have it print
// "Please enter an actual day of the week.” to the console if an error occurs.
            catch (ArgumentException)
            {
                Console.WriteLine("That entry is not a day of the week.");
            }






            Console.ReadLine();
        }
    }
}