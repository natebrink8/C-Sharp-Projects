using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Math
    {
        // 1. Create a class with a method that takes 2 integers as parameters, with 1 being optional.
        // Have the method do a math operation and return an integer result:
        public int Method1(int i)       // Method1: Required integer.
        {
            return i * 3;               // 
        }

        public int Method2(int nullableOptionalJ)       // Method2: Optional integer.
        {
            return nullableOptionalJ + 10;
        }
    }
}
