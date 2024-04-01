using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
// 2a. In the Main() method of the console app, instantiate the class and
            Math math = new Math();

// 2b. call the one method, passing in an integer. Display the result to the screen.
            int i = 7;
            Console.WriteLine("7 minus 2 = " + math.Reduction(i));
            Console.WriteLine("\r");

// 3a. (set a decimal variable to pass)
// 3b. return the answer as an integer.
            decimal j = 8.00m;    // set a decimal variable to pass.
            // Decimal var j = 8.00 and is divided by 2 so should be 4:
            Console.WriteLine("As an integer, 8.00 divided by 2 = " + math.Reduction(j));
            Console.WriteLine("\r");

// 5b. return the answer as an integer.
// 6. In the Main() method of the console app, instantiate the class and call the third method,
// passing in a string that equates to an integer. Display the result to the screen:
            string k = "10";                    // Set string variable to value of "10".
            Console.WriteLine("Variable k is a string but passed as an integer is " + math.Reduction(k));
            Console.WriteLine("\r");

            Console.ReadLine();
        }
    }
}

