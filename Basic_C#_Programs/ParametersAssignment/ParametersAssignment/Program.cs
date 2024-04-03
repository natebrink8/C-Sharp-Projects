using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> teamOne = new Employee<string>();
            // 3a.instantiate an employee object with type "string" as its generic parameter.
            // 3b. Assign a list of strings as the property value of Things:
            teamOne.Things = new List<string>() { "Desk", "Chairs", "Laptops" };

            // 4a. Instantiate an Employee object with type "int"
            // as its generic parameter:
            Employee<int> teamTwo = new Employee<int>();

            // 4b. Assign a list of integers as the property value of Things:
            teamTwo.Things = new List<int>() { 1, 2, 3 };

            // 5. Create a loop that prints all of the Things to the Console:
            for (int i = 0; i < teamOne.Things.Count; i++)
            {
            Console.WriteLine(teamOne.Things[i]);
            }
            Console.WriteLine("\r");

            for (int i = 0; i < teamTwo.Things.Count; i++)
            {
                Console.WriteLine(teamTwo.Things[i]);
            }

            Console.ReadLine();
        }
    }
}

