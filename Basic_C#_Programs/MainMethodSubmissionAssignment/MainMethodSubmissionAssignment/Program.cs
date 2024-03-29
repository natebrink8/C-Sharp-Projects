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
            int mathSubtract = math.Reduction(i);
            Console.WriteLine(mathSubtract);
            Console.WriteLine("\r");

// 3b. return the (3a, in the Math.cs class file) answer as an integer.
            int mathDivision = Decimal.ToInt32(math.DecimalDivision(i));    // Var i = 7 and is divided by 2 so = 3.5 but converted to int here so just 3.
            Console.WriteLine(mathDivision);
            Console.WriteLine("\r");

// 4a. In the Main() method of the console app, instantiate the class [Why is this asked for; the class is already instantiated.]
// 4b. call the second method, passing in a decimal. Display the result to the screen.
            float mathDivisionDecimal = Convert.ToSingle(math.DecimalDivision(i));    // 
            Console.WriteLine(mathDivisionDecimal);
            Console.WriteLine("\r");


// 5b. return the answer as an integer.
// 6. In the Main() method of the console app, instantiate the class and call the third method,
// passing in a string that equates to an integer. Display the result to the screen:
            string j = "10";                    // Set string variable to value of "10".
            int stringToInt = int.Parse(j);     // Set int var and use Parse to convert the value of j.
            Console.WriteLine(stringToInt);     // Write that shiny, sweet goodness.
            Console.WriteLine("\r");

            Console.ReadLine();
        }
    }
}

