using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
// 2. In the Main() method of the console app, instantiate the class:
            Optional optional = new Optional();

// 3. Ask the user to input two numbers, one at a time.
// Let them know they don't have to enter a second number:
            Console.WriteLine("Please provide a number greater than Zero.");
            int requiredInput = int.Parse(Console.ReadLine());
            //bool requiredInputBool = true;
            Console.WriteLine("\r");

            Console.WriteLine("Provide an OPTIONAL second number! (otherwise, just hit Enter:)");
            string optionalInput = Console.ReadLine();
            if (optionalInput == "")
            {
                Console.WriteLine(optional.Method1(requiredInput));
            }
            else
            {
                int optionalInputInt = Convert.ToInt32(optionalInput);
                Console.WriteLine(optional.Method1(requiredInput, optionalInputInt));
            }
            Console.WriteLine("\r");

            Console.ReadLine();
        }
    }
}
