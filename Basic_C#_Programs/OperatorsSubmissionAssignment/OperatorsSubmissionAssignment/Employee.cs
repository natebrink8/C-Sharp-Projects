using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        // 1. Create an Employee class with
        // Id, FirstName and LastName properties:
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. In the Employee class, overload the "==" operator
        // so it checks if two Employee objects are equal by comparing Id.
        // Remember comparison operators must be overloaded in pairs:
        public static bool EmployeeCheck(int Id)
        {
            if (Id == 1)
            {
                //Console.WriteLine("Employee1 and Employee2 both have an ID of: " + Id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EmployeeCheck(int Id, string FirstName, string LastName)
        {
            if (Id != 1)
            {
                //Console.WriteLine("Employee1 and Employee2 do not both have an ID of: " + Id);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
