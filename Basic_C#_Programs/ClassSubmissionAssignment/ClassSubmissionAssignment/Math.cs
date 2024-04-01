using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Math
    {
// 1. Create a class. In that class, create a void method that outputs an integer.
// Have the method divide the data passed to it by 2.
        public void Methy(int i)
        {
            Console.WriteLine(i = i / 2);
        }

// Create a method:
        public int Methy2(int par1, int par2)
        {
            int parpar = par1 * par2;
            return parpar;
        }

// 4. Create a method with output parameters.
// 5. Overload a method.

        //Same method name used w/strings to concatenate the 2 values:
        public string Methy2(out string str1, string str2)
        {
            str1 = "Nate";
            str2 = "Brink";
            return str2;
        }
    }
}
