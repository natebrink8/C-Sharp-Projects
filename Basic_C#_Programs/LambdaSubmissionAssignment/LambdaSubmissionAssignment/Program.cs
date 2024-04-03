using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
// 2. In the Main() method, create a list of at least 10 employees.
// At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id=1, FirstName="Nate", LastName="Brink"},
                new Employee() {Id=2, FirstName="Joe", LastName="Buck"},
                new Employee() {Id=3, FirstName="Joe", LastName="Smith"},
                new Employee() {Id=4, FirstName="Tom", LastName="Foreman"},
                new Employee() {Id=5, FirstName="David", LastName="Hasselhoff"},
                new Employee() {Id=6, FirstName="Harry", LastName="Armpits"},
                new Employee() {Id=7, FirstName="Sally", LastName="Jones"},
                new Employee() {Id=8, FirstName="Suzie", LastName="Rosen"},
                new Employee() {Id=9, FirstName="Tina", LastName="Chauncey"},
                new Employee() {Id=10, FirstName="Bonnie", LastName="Woodworth"}
            };

// 3. Using a foreach loop, create a new list of all employees with
// the first name “Joe”. In your comparison statement, remember
// to reference the property of the object you are checking.
            List<Employee> teamJoe = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    teamJoe.Add(emp);
                    Console.WriteLine("Team Joe Member: " + emp.FirstName + " " + emp.LastName);
                        // CHECK: above line writes "Joe" names to the console.
                }
            }
            Console.WriteLine("\r");


// 4. Perform the same action again, but this time with a lambda expression.
            List<Employee> teamJoe2 = employees.FindAll(e => e.FirstName == "Joe").ToList();
            foreach (Employee e in teamJoe2)
            {
                Console.WriteLine("Team Joe LambdaLambdaLambda: " + e.FirstName + " " + e.LastName);
                    // CHECK: above line writes "Lambda Joe" names to the console.
            }
            Console.WriteLine("\r");


// 5. Using a lambda expression, make a list
// of all employees with an Id number greater than 5.
            List<Employee> teamFivePlus = employees.FindAll(f => f.Id > 5).ToList();
            foreach (Employee f in teamFivePlus)
            {
                Console.WriteLine("Team Five Plus: " + f.FirstName + " " + f.LastName + " with the ID:\t" + f.Id);
                    // CHECK: above line writes [ID over 5] employees to the console.
            }
            Console.WriteLine("\r");
            Console.WriteLine("how YOU doin'...");

            Console.ReadLine();
        }
    }
}
