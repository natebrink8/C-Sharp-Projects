using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
// 2. In the Main() method, instantiate that class:
            Math math = new Math();

// 3a. Have the user enter a number. Call the method on that number:
            Console.WriteLine("Please provide an even number.");
            int i = Convert.ToInt32(Console.ReadLine());
// 3b. Display the output to the screen. It should be the entered number/2:
            Console.WriteLine("Your number, divided by 2 is:");
            math.Methy(i);
            Console.WriteLine("\r");


            // Call the out parameters:
            string str1 = "Joe";
            string str2 = "Smith";
            Console.WriteLine("This is the value of str1 in Main: " + str1);
            Console.WriteLine("This is the value of str2 in Main: " + str2);

            // Calls the method and references the string values:
            Console.WriteLine("This is my method returned: " + math.Methy2(out str1, str2));
            Console.WriteLine("This is the value of str1 in Main after my method: " + str1);
            Console.WriteLine("This is the value of str2 in Main after my method: " + str2);

// Static class:
            int a = 12;
            Console.WriteLine("12 minus 2 equals " + Wheee.Cling(a));

            Console.ReadLine();
        }
    }
}
