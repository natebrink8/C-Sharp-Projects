using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Tech Academy.");             // Write "The Tech Academy."
        Console.WriteLine("Student Daily Report.");         // Write "Student Daily Report."

        Console.WriteLine("What is your name?");            // Ask student for their name.
        Console.ReadLine();                                 // Read the name.

        Console.WriteLine("What course are you on?");       // Ask student which course they are on.
        Console.ReadLine();                                 // Read the course name.

        Console.WriteLine("What page number?");             // Ask student what page number they are on.
        Console.ReadLine();                                 // Read the page number.

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");      // Ask student if they need help.
        Console.ReadLine();                                 // Read the help response.

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");       // Ask student for positive experiences.
        Console.ReadLine();                                 // Read the positive variable with data type string.

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");                // Ask student for feedback.
        Console.ReadLine();                                 // Read the feedback variable with data type string.

        Console.WriteLine("How many hours did you study today?");       // Ask student how many hours they studied.
        Console.ReadLine();                                 // Read the hoursToday variable with data type int.

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");     // SAY THANK YOU!
        Console.ReadLine();                                 // Display THANK YOU! ;-)
    }
}
