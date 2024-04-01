using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace MethodSubmissionAssignment2
{
    public class Optional
    {
        //1. Create a class. In that class, create a method that takes two integers
        //as parameters. Make one of them optional. Have the method do a math
        //operation and return an integer result:
        public int Method1(int required, int optional = 10)    // Method 1: request 2 numbers inthe console, the second is optional.
        {
            int requiredFormula = required * 3;
            int optionalFormula = optional + 25;
            return requiredFormula + optionalFormula;

        }
    }
}
