using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
// 3. In the "Program.cs" file, instantiate two objects of the Employee class
// and assign values to their properties. Then compare the two Employee objects
// using the newly overloaded operators and display the results.
            Employee employee = new Employee();
            int squadA = 1;
            string squadB = "Nate";
            string squadC = "Brink";

            // TEST for TRUE:
            Console.WriteLine("Squad A is 1 and the ID is 1 so this should say TRUE: " + Employee.EmployeeCheck(Id: squadA, FirstName: squadB, LastName: squadC));
            Console.WriteLine("\r");

            // TEST for FALSE:
            int squadD = 2;
            string squadE = "Nate";
            string squadF = "Brink";


            Console.WriteLine("Squad D is 2 and the ID is 1 so this should say FALSE: " + Employee.EmployeeCheck(Id: squadD, FirstName: squadE, LastName: squadF));




            Console.ReadLine();
        }
    }
}
