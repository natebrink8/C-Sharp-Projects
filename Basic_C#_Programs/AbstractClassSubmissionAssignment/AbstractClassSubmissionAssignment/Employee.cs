using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
// 3. Create another class called Employee and
// have it inherit from the Person class:
    public class Employee : Person
    {
// 4. Implement the SayName() method
// inside of the Employee class:
        public override string SayName(string firstName, string lastName)
        {
            return base.SayName(firstName, lastName);
        }

    }
}
