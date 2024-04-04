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
// 2. Create a variable using the keyword "var."
            Console.WriteLine("Please enter your Username.");
            var usernameInput = Console.ReadLine();
// 1. Create a const variable.
            const string welcome = "Welcome to our family!";

            Flyer obj1 = new Flyer(usernameInput);
            Console.WriteLine(welcome + " " + obj1.username + " " + obj1.airline);
            
            Flyer obj2 = new Flyer("nbrink");
            Console.WriteLine(welcome + " " + obj2.username + " " + obj2.airline);

            Flyer obj3 = new Flyer("ajahns", "Portland Airlines");
            Console.WriteLine(welcome + " " + obj3.username + " " + obj3.airline);


            Console.ReadLine();
        }
    }
}
