using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // TESTING VARIABLES:
            //person.FirstName = "Nate";
            //person.LastName = "Brink";
            // CALL the Person class method for name display:
            // person.SayName();

// 4. Inside of the Main method, instantiate and initialize an Employee
// object with a first name of "Sample" and a last name of "Student":
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

// 5. Call the superclass method SayName()
// on the Employee object:
            employee.SayName();

            Console.ReadLine();
        }
    }
}
