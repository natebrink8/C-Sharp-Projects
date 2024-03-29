using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Math
    {
// 1. Create a class with a method that will take in an integer, create a math operation
// for this integer (addition, subtraction, etc.), then return the answer as an integer:
// FIRST METHOD
        public int Reduction(int i)
        {
            return i - 2;               // Subtract 2 from the integer parameter taken in.
        }

// 3a. Add a second method to the class with the same name
// that will take in a decimal, create a different math operation for it:
// SECOND METHOD
        public decimal DecimalDivision(decimal i)
        {
            return i/2;               // Divide i by 2, generating a decimal value to use in Program.cs.
        }

// 5a. Add a third method to the class, with the same name, that will take in a string,
// convert it to an integer if possible, do a different math operation to it:
// THIRD METHOD
        public string StringConversion(string j)
        {
            return j;               // 
        }
    }
}
