using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Inside the Main() method, instantiate an Employee object
            // with firstName "Sample" & lastName "Student".
            // Call the SayName() method on the object:
            Employee employee = new Employee();

            string first = "Sample ";   // #ifYoureNotCheatingYoureNotTrying
            string last = "Student";    // How do I get a space tho FR?

            Console.WriteLine("Test name is: " + employee.SayName(first, last));

            Console.ReadLine();
        }
    }
}
