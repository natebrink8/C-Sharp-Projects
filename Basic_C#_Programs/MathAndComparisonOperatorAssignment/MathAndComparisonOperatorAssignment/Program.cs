using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");           // Initialize program by displaying "Anonymous Income Comparison Program"

        Console.WriteLine("Person 1");                                      // Display "Person 1".
        Console.WriteLine("Please enter your Hourly Rate:");                // Request the Hourly Rate.
        string rate1 = Console.ReadLine();                                  // Create variable to read the string input.
        decimal hourlyRate1 = Convert.ToDecimal(rate1);                     // Set decimal data type variable for Hourly Rate number, converting from rate1 string.
        Console.WriteLine("Please enter your Hours worked per week:");      // Request the Hours worked per week.
        string hours1 = Console.ReadLine();                                 // Create variable to read the string input.
        byte weeklyHours1 = Convert.ToByte(hours1);                         // Set byte data type variable for Weekly Hours number, converting from hours1 string.
        Console.WriteLine("\r");

        Console.WriteLine("Person 2");                                      // Display "Person 2".
        Console.WriteLine("Please enter your Hourly Rate:");                // Request the Hourly Rate.
        string rate2 = Console.ReadLine();                                  // Create variable to read the string input.
        decimal hourlyRate2 = Convert.ToDecimal(rate2);                     // Set decimal data type variable for Hourly Rate number, converting from rate2 string.
        Console.WriteLine("Please enter your Hours worked per week:");      // Request the Hours worked per week.
        string hours2 = Console.ReadLine();                                 // Create variable to read the string input.
        byte weeklyHours2 = Convert.ToByte(hours2);                         // Set byte data type variable for Weekly Hours number, converting from hours2 string.
        Console.WriteLine("\r");

        Console.WriteLine("Annual salary of Person 1:");                    // Display header.
        decimal annualSalaryP1 = hourlyRate1 * weeklyHours1 * 52;           // Set decimal variable for the annual salary calculation: rate*weekly hours*52 (weeks in a year).
        Console.WriteLine("$" + annualSalaryP1);                            // Display Annual Salary value.
        Console.WriteLine("\r");

        Console.WriteLine("Annual salary of Person 2:");                    // Display header.
        decimal annualSalaryP2 = hourlyRate2 * weeklyHours2 * 52;           // Set decimal variable for the annual salary calculation: rate*weekly hours*52 (weeks in a year).
        Console.WriteLine("$" + annualSalaryP2);                            // Display Annual Salary value.
        Console.WriteLine("\r");

        Console.WriteLine("Does Person 1 make more money than Person 2?");  // Display header.
        bool trueOrFalse = annualSalaryP1 > annualSalaryP2;                 // Use boolean data type for variable to check if P1 annual salary > P2 annual salary.
        Console.WriteLine("It is " + trueOrFalse + " that Person 1 makes more money than Person 2.");

        Console.ReadLine();
    }
}
