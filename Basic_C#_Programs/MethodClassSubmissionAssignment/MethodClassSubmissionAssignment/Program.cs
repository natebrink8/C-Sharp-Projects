using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
// 2. In the Main() method of the console app, instantiate the class.
            Math math = new Math();

            int num2 = 10;
            int num1 = 20;

// 3. Call the method in the class, passing in two numbers.
            math.Method1(num1, num2);   // PASSING in two numbers.
            Console.WriteLine("\r");

// 4. Call the method in the class, specifying the parameters by name.
            math.Method1(num2: 66, num1: 53);


            Console.ReadLine();
        }
    }
}
