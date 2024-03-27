using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Addition:");
        int num1 = 8;                   // OFF TOP: set numeric variables
        int num2 = 4;                   // for int1 and int2 for use throughout.
        int addNumbers = num1 + num2;
        Console.WriteLine("8 + 4 equals " + addNumbers + ".");
        Console.WriteLine("\r");


        Console.WriteLine("2. Subtraction:");
        int subtractNumbers = num1 - num2;
        Console.WriteLine("8 - 4 equals " + subtractNumbers + ".");
        Console.WriteLine("\r");


        Console.WriteLine("3. Multiplication:");
        int multiplyNumbers = num1 * num2;
        Console.WriteLine("8 x 4 equals " + multiplyNumbers + ".");
        Console.WriteLine("\r");


        Console.WriteLine("4. Division:");
        int divideNumbers = num1 / num2;
        Console.WriteLine("8 / 4 equals " + divideNumbers + ".");
        Console.WriteLine("\r");

        Console.ReadLine();
    }
}
