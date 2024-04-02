﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Inside the Main() method, instantiate an Employee object
            // with firstName "Sample" & lastName "Student".
            // Call the SayName() method on the object:
            Employee employee = new Employee();
            IQuittable quitter = new Employee();

            string first = "Sample";
            string last = "Student";

            Console.WriteLine("Test name is: " + employee.SayName(first, last));

// POLYMORPHISM SUBMISSION ASSIGNMENT: 3. Use polymorphism to create
// an object of type IQuittable and call the Quit() method on it.
// Hint: an object can be of an interface type if it implements that specific interface:
            quitter.Quit(employee);

            Console.ReadLine();
        }
    }
}
