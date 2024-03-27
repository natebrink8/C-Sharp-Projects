using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");     // Display greeting and header.
        Console.WriteLine("Please provide the package weight.");    // Prompt the user for package weight.
        int weight = Convert.ToInt32(Console.ReadLine());           // Set int var for weight, feeding the console value to the converting int value.
        int maxWeight = 50;                                         // Set int var for maximum package weight of 50.

        if (weight > maxWeight)                                     // If the package weight is greater than the maximum weight (set above as 50)...
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");     // If greater than 50, display this text; fin.
        }
        else if (weight <= maxWeight)                               // Else if weight less than/equal to 50...
        {
            Console.WriteLine("Please provide package width.");     // Display prompt for package width.
            int width = Convert.ToInt32(Console.ReadLine());        // Set int var for width, feeding the console value to the converting int value.
            Console.WriteLine("Please provide package height.");    // Display prompt for package height.
            int height = Convert.ToInt32(Console.ReadLine());       // Set int var for height, feeding the console value to the converting int value.
            Console.WriteLine("Please provide package length.");    // Display prompt for package length.
            int length = Convert.ToInt32(Console.ReadLine());       // Set int var for length, feeding the console value to the converting int value.
            int maxDimensions = 50;                                 // Set int var for maximum dimension value of 50.
            int totalDimensionsAdd = width + height + length;       // Set int var to add the width, height, and length dimensions.
            int totalAllDimensionsMult = (width * height * length * weight) / 100;  // Set int var for calculation (dimensions*weight) divided by 100.

            if (totalDimensionsAdd > maxDimensions)                 // If the addition of the dimensions is greater than the maximum dimensions (set above as 50)...
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");                    // If greater than 50, display this text; fin.
            }
            else Console.WriteLine("Your estimated total for shipping this package is: $" + totalAllDimensionsMult + ".00");    // Else display this text, with quote in dollars.
            Console.WriteLine("Thank you!");                        // Say THANK YOU!!
        }


        Console.ReadLine();
    }
}
