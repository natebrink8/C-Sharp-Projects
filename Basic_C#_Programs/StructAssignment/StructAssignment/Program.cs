using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Amount amtvalues = new Amount();

// 2. In the Main() method, create an object
// of data type Number and assign an amount to it:
            int amt1 = 2;
            int amt2 = 3;

// 3. Print this amount to the console:
            Console.WriteLine(amt1);
            Console.WriteLine(amt2);
            // These display as whole numbers in the console-- no direction
            // in LMS provided as to whether they should be decimal, based
            // on the struct format or if int is how the output is intended.

            Console.ReadLine();
        }
    }
}
