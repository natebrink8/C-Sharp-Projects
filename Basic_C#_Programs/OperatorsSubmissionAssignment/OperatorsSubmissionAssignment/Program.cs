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
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Nate";
            employee2.Id = 2;
            employee2.FirstName = "Frank";

            Console.WriteLine(employee1 != employee2);

            Console.ReadLine();
        }
    }
}
