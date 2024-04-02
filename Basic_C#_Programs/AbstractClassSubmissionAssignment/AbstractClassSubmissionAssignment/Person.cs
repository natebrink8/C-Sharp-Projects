using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person
    {
// 1. Create an abstract class called Person
// with two properties: string firstName and string lastName.
        public string firstName { get; set; }
        public string lastName { get; set; }

        // 2. Give it the method SayName().
        public virtual string SayName(string firstName, string lastName)
        {
            return firstName + lastName;
        }

    }
}
