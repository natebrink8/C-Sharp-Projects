using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaTestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testclass = new TestClass();

            Console.WriteLine("Please enter a number to perform math fun!");
            int mathNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result of the equation is: " + testclass.Method1(mathNum));



        }
    }
}
