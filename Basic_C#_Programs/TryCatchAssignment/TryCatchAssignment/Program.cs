using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
// 1. Ask the user for their age.
            Console.WriteLine("Please provide your age.");

// 3. Exceptions must be handled using "try/catch."
            try
            {
                int ageInput = Convert.ToInt32(Console.ReadLine());
                if (ageInput <= 0)
                {
                    throw new AgeException();
                }
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - ageInput;


// 2. Display the year the user was born.
                Console.WriteLine("Quick math says you were born in " + yearBorn + "! ;-)");
                Console.WriteLine("\r");
                Console.ReadLine();
            }

// 4. Display error message if the user enters zero or negative numbers:
            catch (AgeException)
            {
                Console.WriteLine("SYNTAX ERROR: that is an invalid age value.");
                Console.ReadLine();
                return;
            }
// 5. Display a general message if an exception was caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("No more tries.");
            }


            Console.ReadLine();
        }
    }
}
