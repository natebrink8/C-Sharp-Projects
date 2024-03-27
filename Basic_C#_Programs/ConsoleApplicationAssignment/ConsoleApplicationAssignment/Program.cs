using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Please provide a number to be multiplied by fifty.");         // Display the input request.
        string num1 = Console.ReadLine();                                                   // Create variable to read the string input.
        int providedNum1 = Convert.ToInt32(num1);                                           // Create integer variable, converting from the string variable.
        long bigProvidedNum1 = providedNum1 * 50;                                           // Use long data type for input over 10,000,000 and set formula for multiplication.
        Console.WriteLine(providedNum1 + " times 50 is: " + bigProvidedNum1 + ".");         // Display result with friendly text.
        Console.WriteLine("\r");                                                            // Line break for beautification.

        Console.WriteLine("2. Please provide a number to be increased by twenty-five.");    // Display the input request.
        string num2 = Console.ReadLine();                                                   // Create variable to read the string input.
        int providedNum2 = Convert.ToInt32(num2);                                           // Create integer variable, converting from the string variable.
        int add25ProvidedNum2 = providedNum2 + 25;                                          // Use int data type for variable for math equation and set formula for addition.
        Console.WriteLine(providedNum2 + " plus 25 is: " + add25ProvidedNum2 + ".");        // Display result with friendly text.
        Console.WriteLine("\r");                                                            // Line break for beautification.

        Console.WriteLine("3. Please provide a number to be divided by twelve and a half.");    // Display the input request.
        string num3 = Console.ReadLine();                                                       // Create variable to read the string input.
        double providedNum3 = Convert.ToDouble(num3);                                           // Create double variable, converting from the string variable for division and decimals.
        double divideProvidedNum3 = providedNum3 / 12.5;                                        // Use double data type for variable for math equation and set formula for division.
        Console.WriteLine(providedNum3 + " divided by 12.5 is: " + divideProvidedNum3 + ".");   // Display result with friendly text.
        Console.WriteLine("\r");                                                                // Line break for beautification.

        Console.WriteLine("4. Please provide a number greater or less than 50 (True for greater than, False for less than.)");  // Display the input request.
        string num4 = Console.ReadLine();                                                                                       // Create variable to read the string input.
        int providedNum4 = Convert.ToInt32(num4);                                                                               // Create integer variable, converting from the string variable.
        bool trueOrFalse1 = providedNum4 > 50;                                                                                  // Use boolean data type for variable for true/false check in comparison operator formula.
        Console.WriteLine("It is " + trueOrFalse1.ToString() + " that " + providedNum4 + " is greater than 50.");               // Display result with friendly text.
        Console.WriteLine("\r");                                                                                                // Line break for beautification.

        Console.WriteLine("5. Please provide a number greater than 7 (to be divided by 7 w/any remainder to be displayed.)");   // Display the input request.
        string num5 = Console.ReadLine();                                                                                       // Create variable to read the string input.
        int providedNum5 = Convert.ToInt32(num5);                                                                               // Create integer variable, converting from the string variable.
        int remainder = providedNum5 % 7;                                                                                       // Use int data type for variable for math equation and set formula for division and remainder.
        Console.WriteLine(providedNum5 + " divided by 7 leaves a remainder of " + remainder + ".");                             // Display result with friendly text.
        Console.WriteLine("\r");                                                                                                // Line break for beautification.




        Console.ReadLine();
    }
}
