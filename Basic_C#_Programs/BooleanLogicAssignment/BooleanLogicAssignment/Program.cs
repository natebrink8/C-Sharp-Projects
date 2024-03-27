using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your age?");         // Display the input request.
        string age = Console.ReadLine();                // Create variable to read the string input.
        int age1 = Convert.ToInt32(age);                // Create integer variable, converting from the string variable.

        Console.WriteLine("Have you ever had a DUI? (Please only True or False.)");  // Display the input request.
        string dui = Console.ReadLine();                // Create variable to read the string input.
        bool dui1 = Convert.ToBoolean(dui);

        Console.WriteLine("How many speeding tickets do you have?");    // Display the input request.
        string tickets = Console.ReadLine();                            // Create variable to read the string input.
        int tickets1 = Convert.ToInt32(tickets);

        bool qualified = (age1 > 15 && dui1 == false && tickets1 < 3);
        Console.WriteLine("Qualified: " + qualified);

        Console.ReadLine();
    }
}

