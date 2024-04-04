using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    public class Flyer
    {   // SEATTLE Airlines!
        public string username;
        public string airline = "Seattle Airlines";

// 3. Chain two constructors together.
        public Flyer(string username) : this(username, "Seattle Airlines")
        { }
        public Flyer(string username, string airline)
        {
            this.username = username;
            this.airline = airline;
        }

    }
}
