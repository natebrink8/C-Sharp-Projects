using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Asks the user for a number.
            Console.WriteLine("Please enter a number.");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            // 2. Logs that number to a text file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\ochob\Logs\log_inputassignment.txt", true))
            {
                file.WriteLine(numberInput);
            }
            Console.WriteLine("\r");

            // 3. Prints the text file back to the user.
            Console.WriteLine("You have listened to your heart and chosen the number " + numberInput + ".");

            Console.ReadLine();
        }
    }
}
