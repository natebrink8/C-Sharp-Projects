using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();     // Set the created Class "Math" to use in this program.

// In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Please enter a number to perform math fun!");
            int mathNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

// Call each method, passing the user input to the method. Display the returned integer to the screen:
            Console.WriteLine(mathNum + " + 5 = " + math.Method1(mathNum));
            Console.WriteLine("\r");

            Console.WriteLine(mathNum + " + 7 = " + math.Method2(mathNum));
            Console.WriteLine("\r");

            Console.WriteLine(mathNum + " + 9 = " + math.Method3(mathNum));
            Console.WriteLine("\r");


            Console.ReadLine();     // All I wanna do is zooma zoomzoom zoom.
        }
    }
}