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


            Console.ReadLine();
        }
    }
}
