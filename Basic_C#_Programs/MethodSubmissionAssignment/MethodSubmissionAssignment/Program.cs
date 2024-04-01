using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class:
            Math math = new Math();
            int i = Convert.ToInt32(Console.ReadLine());
            int? nullableOptionalJ = Convert.ToInt32(Console.ReadLine());
            if (nullableOptionalJ.HasValue)
            {
                Console.WriteLine(nullableOptionalJ.Value);
            }
            else
            {
                Console.WriteLine("Optional value not provided.");
            }


            // 3a. Ask the user to input 2 numbers, 1 at a time.
            Console.WriteLine("Please provide a number greater than Zero.");
            Console.WriteLine(i);       // 4. Call the method in the class, passing in the one or two numbers entered.
            Console.WriteLine("\r");

            // 3b. Let them know they need not enter anything for the second number.
            Console.WriteLine("Provide an OPTIONAL second number! (otherwise, just hit Enter:)");
            Console.WriteLine(j);       // 4. Call the method in the class, passing in the one or two numbers entered.
            Console.WriteLine("\r");

            // 4. Call the method in the class, passing in the one or two numbers entered.
            int num1Method = math.Method1(i);   // Set int var for Math class Method1/i.
            int num2Method = math.Method2(nullableOptionalJ);   // Set int var for Math class Method2/j.

            // 5. Try various combinations of numbers on the code, including having no second number.



            Console.ReadLine();
        }
    }
}