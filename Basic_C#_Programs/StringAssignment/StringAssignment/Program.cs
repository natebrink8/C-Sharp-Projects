using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // Concatenate three strings.
        // "We three strings, con-ca-tenate are..." o.O
        string lebowskiText1 = "She";           // First text string variable.
        string lebowskiText2 = "Kidnapped";     // Second text string variable.
        string lebowskiText3 = "Herself";       // Third text string variable.
        string bigLebowski = lebowskiText1 + lebowskiText2 + lebowskiText3;     // String variable to concatenate the strings.

        Console.WriteLine("May the concatenation of the tri-text begin...");    // Concatenate 3 strings.
        Console.WriteLine("Lebowski Text 1: " + lebowskiText1);                 // Display the text: number 1.
        Console.WriteLine("Lebowski Text 2: " + lebowskiText2);                 // Display the text: number 2.
        Console.WriteLine("Lebowski Text 3: " + lebowskiText3);                 // Display the text: number 3.
        Console.WriteLine("The Big Lebowski concatenates! " + bigLebowski);     // Display the concatenated text.
        Console.WriteLine("We believes in nusseeng, Lebowski.");                // Must be exhausting.
        Console.WriteLine("\r");                                                // Ties the room together.
        Console.WriteLine("\r");

        // Convert a string to uppercase.
        Console.WriteLine("Convert a string to uppercase");                     // Name the next section.
        string lowercaseText = "nate";                                          // Set the string variable for the lowercase text.
        string upperCaseText = lowercaseText.ToUpper();                         // Set the string variable for the uppercase text.
        Console.WriteLine("original text is lowercase: \t" + lowercaseText);    // Display the original lowercaseText value.
        Console.WriteLine("CONVERTED TEXT IS UPPERCASE: \t" + upperCaseText);   // Display the converted uppercaseText value.
        Console.WriteLine("\r");
        Console.WriteLine("\r");

        // Create a Stringbuilder and build a paragraph of text, one sentence at a time.
        StringBuilder sb = new StringBuilder();
        string line = "The second line of text.";
        string line2 = "The third line of text.";
        string line3 = "The fourth line of text.";
        int number = 123;

        // Append 4 lines of text.
        Console.WriteLine("THE REVEAL!!... displaying a paragraph... one line at a time.");     // Just display the one line of text.
        sb.AppendLine("The first line of text.");
        Console.WriteLine(sb.ToString());

        Console.WriteLine("THE TOP 2 lines of text.");              // Display the top 2 lines of text.
        sb.AppendLine(line);
        Console.WriteLine(sb.ToString());

        Console.WriteLine("THE TOP 3 lines of text.");              // Display the top 3 lines of text.
        sb.AppendLine(line2);
        Console.WriteLine(sb.ToString());

        Console.WriteLine("ALL 4 lines of text!");                  // Display all 4 lines of text.
        sb.AppendLine(line3);
        Console.WriteLine(sb.ToString());
        Console.WriteLine("\r");
        Console.WriteLine("\r");




        Console.ReadLine();
    }
}
