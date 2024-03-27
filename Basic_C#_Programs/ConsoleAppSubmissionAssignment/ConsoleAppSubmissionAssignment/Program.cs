using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess my favorite color.");
        string color = Console.ReadLine();
        bool colorGuess = color == "blue";

        do
        {
            switch (color)
            {
                case "red":                                                 // Case for other colors.
                    Console.WriteLine("You said red. Go back to bed.");     // Console display text to keep 'em coming!
                    Console.WriteLine("Guess again.");                      // (Lather, Rinse, Repeat in below case blocks.)
                    color = Console.ReadLine();
                    break;
                case "yellow":
                    Console.WriteLine("Yellow is not for this fellow.");
                    Console.WriteLine("Guess again.");
                    color = Console.ReadLine();
                    break;
                case "green":
                    Console.WriteLine("Green is clean, ya know what I mean? But I'm not keen.");
                    Console.WriteLine("Guess again.");
                    color = Console.ReadLine();
                    break;
                case "purple":
                    Console.WriteLine("Purple is a \"No\" for me.");
                    Console.WriteLine("Guess again.");
                    color = Console.ReadLine();
                    break;
                case "orange":
                    Console.WriteLine("Orange is a juice, you silly goose!");
                    Console.WriteLine("Guess again.");
                    color = Console.ReadLine();
                    break;
                case "blue":                                                // Winner! Winner! Chicken dinner!
                    Console.WriteLine("Look at you, guessing blue. This much is true... my favorite color is blue!");
                    colorGuess = true;                                      // Set the colorGuess var to true to end this loop.
                    break;
                default:                                                    // Default catch-all for all other responses entered in console.
                    Console.WriteLine("My liege... My Lord... What!!  Incorrect.");
                    Console.WriteLine("Guess another color, please.");
                    color = Console.ReadLine();
                    break;
            }
        }
        while (!colorGuess);        // While the colorGuess variable is false (see top: favorite color = blue).

        Console.ReadLine();         // Read 
    }
}
