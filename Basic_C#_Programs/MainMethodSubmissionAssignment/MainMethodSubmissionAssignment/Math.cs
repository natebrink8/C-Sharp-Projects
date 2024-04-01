using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    public class Math
    {
        // 1. Create a class with a method that will take in an integer, create a math operation
        // for this integer (addition, subtraction, etc.), then return the answer as an integer:
        // FIRST METHOD
        public int Reduction(int i)
        {
            return i - 2;
        }

        // 3a. Add a second method to the class with the same name
        // that will take in a decimal, create a different math operation for it:
        // SECOND METHOD
        public int Reduction(decimal j)
        {
            {
                int jint = decimal.ToInt32(j);
                int jintresult = jint / 2;
                return jintresult;
            }
        }

// 5a. Add a third method to the class, with the same name, that will take in a string,
// convert it to an integer if possible, do a different math operation to it:
// THIRD METHOD
        public int Reduction(string k)
        {
            int kint = Convert.ToInt32(k);
            int kintresult = kint * 10;
            return kintresult;
        }
    }
}