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

// 4. Create a method with output parameters:
        // note: created a method with parameters to provide output;
        // I find an "OUT" coding option online but am unfamiliar:
        public int Methy2(int par1, int par2)
        {
            int parpar = par1 * par2;
            return parpar;
        }

// 5. Overload a method.
        //Same method name used w/strings to concatenate the 2 values:
        public string Methy2(string str1, string str2)
        {
            string strstr = str1 + str2;
            return strstr;
        }

// 6. Declare a class to be static.
        // Static class created; unable to be instantiated in Program:
        static int Methy3(int par3, int par4)
        {
            return par3 + par4;
        }
    }
}
