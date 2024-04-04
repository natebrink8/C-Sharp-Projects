using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flyer flyer = new Flyer();
            // 2. Create a variable using the keyword "var."
            Console.WriteLine("Please enter your Username.");
            var usernameInput = Console.ReadLine();

            Console.WriteLine("Welcome to " + Flyer.airline + ", " + usernameInput + "!");


            Console.ReadLine();
        }
    }
}
