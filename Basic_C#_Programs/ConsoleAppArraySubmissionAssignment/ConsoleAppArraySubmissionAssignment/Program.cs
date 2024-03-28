using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
// Create a one-dimensional Array of strings.
// Ask the user to select an index of the Array and
// then display the string at that index on the screen.
        string[] textArray = { "0: You will enjoy Coke Zero", "1: Only 1 major life change will happen to you next year.", "2: It takes 2 to make a thing go right!", "3: Like Steph Curry, go for 3!", "4: Four chores and seven meals ago... time to TREAT YOSELF!" };
        // The above sets the string array.

        Console.WriteLine("Numerically driven e-fortune-cookies.");
        Console.WriteLine("Please enter 0, 1, 2, 3, or 4.");        // Display options for index entry.
        int arrayChoice = Convert.ToInt32(Console.ReadLine());      // Set int var for index choice, convert the return to int data type.
        Console.WriteLine(textArray[arrayChoice]);                  // Fetch the proper text string from the textArray per the arrayChoice index value.
        Console.WriteLine("\r");


// Create a one-dimensional Array of integers.
// Ask the user to select an index of the Array and
// then display the integer at that index on the screen.
        int[] ochoArray = { 2, 4, 6, 8 };                           // The above sets the string array.
        Console.WriteLine("See who you are in the cheer!");
        Console.WriteLine("Please enter 0, 1, 2, or 3.");           // Display options for index entry.
        int ochoArrayChoice = Convert.ToInt32(Console.ReadLine());  // Set int var for index choice, convert the return to int data type.
        if (ochoArrayChoice == 0 || ochoArrayChoice == 1 || ochoArrayChoice == 2 || ochoArrayChoice == 3)
        {               // ^^^Above line sees if one of the index values were entered.
            Console.WriteLine("You are the " + ochoArray[ochoArrayChoice] + " in this \"2 - 4 - 6 - 8!\" cheer team!");
        }               // ^^^Above line displays whether they're the 2, 4, 6, or 8. Ever Cheerleading #whoDoWeAppreciate

// Add in a message that displays when the user selects an index that doesn’t exist.
        else
        {
            Console.WriteLine("But the directions, though... bye!");
        }
        Console.WriteLine("\r");


// Create a list of strings.
// Ask the user to select an index of the list and
// then display the content at that index on the screen.
        // YOUR KISS IS ON MY LIST
        List<string> lyricList = new List<string>();
        lyricList.Add("Because");
        lyricList.Add("Your Kiss");
        lyricList.Add("Is On");
        lyricList.Add("My List");
        lyricList.Add("I Can't Resist");

        Console.WriteLine("Play Luyrical Name That Tune (enter a value from 0 to 4.)");    // Display options for index entry.
        int nameTuneChoice = Convert.ToInt32(Console.ReadLine());       // Set int var for index choice, convert the return to int data type.
        if (nameTuneChoice == 0 || nameTuneChoice == 1 || nameTuneChoice == 2 || nameTuneChoice == 3 || nameTuneChoice == 4)
        {               // ^^^Above line sees if one of the index values were entered.
            Console.WriteLine("Your song lyrics are... \"" + lyricList[nameTuneChoice] + "\"...");
        }               // ^^^Above line displays the song lyrics based on the index provided.

// (Again adding) in a message that displays when the user selects an index that doesn’t exist.
        else
        {
            Console.WriteLine("Sorry you chose not to play :'(");
        }
        Console.WriteLine("\r");


        Console.ReadLine();
    }
}
