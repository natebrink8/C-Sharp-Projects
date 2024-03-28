using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
// PART ONE
// A one-dimensional array of strings.
        string[] baseballTeams = { "Mariners", "Giants", "Angels", "Dodgers" };

// Ask the user to input some text.
        Console.WriteLine("Please enter some text.");
        string userInput = Console.ReadLine();          // Set string var for user input.

// A loop that iterates through each string in the array and adds the user's text input to the end of each string.
// This step will not output anything to the console, but will update each array element by appending the user's text.
        for (int i = 0; i < baseballTeams.Length; i++)  // For loop to account for each index.
        {
            baseballTeams[i] = baseballTeams[i] + userInput;    // Each array index equals the existing value, appending the console input.

// Then create a second loop that prints off each string in the array one at a time.
            foreach (string team in baseballTeams)      // Foreach value in the array
            {
                Console.WriteLine(team);        // Write to the value.
            }
            Console.WriteLine("\r");        // Line break to separate the console return to make it easier to view.
        }


// PART TWO
// An infinite loop.
        //bool infinity = true;             // Set Boolean var infinity to true.
        //while (infinity)                  // While loop for the set true var.
        //{
        //    Console.WriteLine("I like Santa.");       // Prints infinitely.
        //}
        // Code saved, tested, then commented out in order to move ahead.

// Fix the infinite loop so that it will execute properly.
        bool infinity2 = true;
        while (infinity2)
        {
            Console.WriteLine("I like Santa.");     // This no longer prints infinitely.
            infinity2 = false;
        }
        Console.WriteLine("\r");        // Line break to separate the console view.


// PART THREE
// A loop where the comparison used to determine whether to continue iterating the loop is a < operator.
        int[] outdoorTemp = { 30, 40, 50, 60, 70, 80, 90, 100 };    // Set int array of temperature values.

        for (int i = 0; i < outdoorTemp.Length; i++)       // Foreach loop for temperatures in the array.
        {
            if (outdoorTemp[i] < 60)      // If the temperature is less than 60...
            {
                Console.WriteLine("The outdoor temperature average is " + outdoorTemp[i] + "... do you live in the Northwest, too?"); // Display some weather related small-talk.
            }
        }
        Console.WriteLine("\r");        // Line break to separate the console view.

// Add another loop where the comparison that's used to determine whether to continue iterating the loop is a <= operator.
        int[] outdoorTemp2 = { 30, 40, 50, 60, 70, 80, 90, 100 };   // Set int array of temperature values.

        for (int i = 0; i <= 7; i++)               // Foreach loop for temperatures in the array.
        {
            if (outdoorTemp2[i] <= 40)    // If the temperature is less than or equal to 40...
            {
                Console.WriteLine("The outdoor temperature is " + outdoorTemp2[i] + "... oh my, it's cold!");      // Display more weather related small-talk!
            }
        }
        Console.WriteLine("\r");        // Line break to separate the console view.


// PART FOUR
// A list of strings where each item in the list is unique.
// Ask the user to input text to search for in the list.
// A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
// Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
// Add code that stops the loop from executing once a match has been found.
        List<string> footballTeams = new List<string>() { "Seahawks", "49ers", "Rams", "Cardinals" };   // Create a list of unique strings.

        Console.WriteLine("Enter an NFL team mascot name to search for.");       // Ask user to input text to search for.
        string teamSearch = Console.ReadLine();     // Set string var for user input.
        bool teamFound = false;                     // Set boolean var teamFound flag to false for found team value.

        for (int i = 0; i < footballTeams.Count; i++)   // For loop to account for each index.
            if (teamSearch == footballTeams[i])         // If the searched team name quals a team name in the list...
            {
                teamFound = true;                   // Set the teamFound flag to true.
                break;                              // Break out of the loop.
            }
        if (teamFound)                              // If the teamFound flag is true...
        {
            Console.WriteLine("We found the " + teamSearch + " - perfect! " + "Index number was: " + footballTeams.IndexOf(teamSearch));    // Display the found team message.
        }
        else
        {
            Console.WriteLine("The " + teamSearch + " are not on the list of teams.");  // Else display the message that the team name searched for is not found.
        }
        Console.WriteLine("\r");        // Line break to separate the console view.


// PART FIVE
// A list of strings that has at least two identical strings in the list.
        List<string> collegeMascots = new List<string>() { "Huskies", "Bears", "Cougars", "Huskies" };   // Create a list of strings with 2 identical strings.

// Ask the user to select text to search for in the list.
        Console.WriteLine("Enter a college mascot to search for.");       // Ask user to input text to search for.
        string mascotSearch = Console.ReadLine();       // Set string var for user input.
        bool mascotFound = false;                       // Set boolean var mascotFound flag to false for found mascot value.

// Create a loop that iterates through the list and then displays the indices
// of the items matching the user-selected text. Ensure to remove any break
// statements that may prevent your code from returning multiple matches.
        for (int i = 0; i < collegeMascots.Count; i++)      // For loop to account for each index.
            if (mascotSearch == collegeMascots[i])          // If the searched mascot name quals a mascot name in the list...
            {
                mascotFound = true;                 // Set the mascotFound flag to true.
                Console.WriteLine("The mascot searched for was found at index: " + i);    // Display the duplicate message for the Huskies.
            }
        if (!mascotFound)                            // If the mascotFound flag is true...
// Add code to the loop to check if the user put in text that isn't on the list and,
// if they did, tells the user their input is not on the list. (NO MULLIGANS!)
        {
            Console.WriteLine("The " + mascotSearch + " are not on the list of college mascots.");      // Display message for mascotSearch values not in the list.
        }
        Console.WriteLine("\r");        // Line break to separate the console view.


// PART SIX
// Create a list of strings that has at least two identical strings in the list.
        List<string> favoriteDrinks = new List<string>() { "Water", "Juice", "Soda", "Beer", "Beer", "Wine", "Wine" };   // Create a list of strings with >2 identical strings.

        // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether it has already appeared
        // in the list. For example, if you had a list of letters: {“A”, “B”, “C”, “D”, “C”}, you could have the following print to the screen:
        //A - this item is unique
        //B - this item is unique
        //C - this item is unique
        //D - this item is unique
        //C - this item is a duplicate

        var fridge = new List<string>();          // Set variable for list of drinks, for unique values.

        foreach (string drink in favoriteDrinks)
        {
            if (fridge.Contains(drink))
            {
                Console.WriteLine(drink + "\t is a duplicate item.");
            }
            else
            {
                Console.WriteLine(drink + "\t is a unique item.");
                fridge.Add(drink);
            }        
        }


        Console.ReadLine();                         // Make with the reading!
        }
    }
