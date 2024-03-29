using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers.
        List<int> intList = new List<int>() { 2, 12, 16, 28, 30 };      // Los numeros buenos.

//Put the loop in a try/catch block. Below and outside of the try/catch block,
//make the program print a message to the display to let you know the program
//has emerged from the try/catch block and continued on with program execution.
        try
        {
            // Ask the user for a number to divide each number in the list by.
            Console.WriteLine("Please provide a number to divide into our list of fancy numbers!");
            int num1 = Convert.ToInt32(Console.ReadLine());         // Convert the string console value to Int.
            Console.WriteLine("\r");

            // Write a loop that takes each integer in the list, divides it by the number the user entered,
            // and displays the result to the screen.
            for (int i = 0; i <= 4; i++)                            // For each index value starting at 0 and under 4...
            {
                Console.WriteLine(intList[i] + " divided by " + num1 + "\t=\t" + intList[i] / num1 + ".");  // Divisive.
            }
            Console.WriteLine("\r");
            Console.ReadLine();             // Display porpoises.
        }

//In the catch block, display the error message to the screen.
//Then try various combinations of user input: valid numbers,
//zero and a string. Ensure the proper error messages display
//on the screen, and that the code after the try/catch block gets executed.
        catch (FormatException ex)                              // Error for string entries.
        {
            Console.WriteLine("Only whole number values can be entered.");
            return;
        }
        catch (DivideByZeroException ex)                        // Error for entry of 0.
        {
            Console.WriteLine("SYNTAX ERROR: #unableToDivideByZero");
        }
        catch (Exception ex)                                    // Error for all else.
        {
            Console.WriteLine(ex.Message);
        }
        finally                                                 // As The Rock says... "FI-NAL-LY."
        {
            Console.ReadLine();
        }


        Console.ReadLine();
    }
}
