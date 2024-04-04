using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    public class Flyer
    {   // SEATTLE Airlines!
        // 1. Create a const variable.
        public string username;
        public const string airline = "Seattle Airlines";

        // 3. Chain two constructors together.
        public Flyer(string username) : this(username, airline)
        { }
        public Flyer(string username, string airline)
        {
            this.username = username;
        }

    }
}
