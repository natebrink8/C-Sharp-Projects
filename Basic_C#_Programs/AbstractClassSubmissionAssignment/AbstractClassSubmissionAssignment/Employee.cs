using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
// 3. Create another class called Employee and
// have it inherit from the Person class:

// POLYMORPHISM SUBMISSION ASSIGNMENT: 2a. Have your Employee class
    // from the previous drill inherit that interface
    public class Employee : Person, IQuittable
    {
        // 4. Implement the SayName() method
        // inside of the Employee class:
        public override string SayName(string firstName, string lastName)
        {
            return base.SayName(firstName, lastName);
        }

// POLYMORPHISM SUBMISSION ASSIGNMENT: 2b. and implement
// the Quit() method in any way you choose:
        public void Quit(Employee employee)
        {
            Console.WriteLine("The Quit method in full effect.");
        }
    }
}
