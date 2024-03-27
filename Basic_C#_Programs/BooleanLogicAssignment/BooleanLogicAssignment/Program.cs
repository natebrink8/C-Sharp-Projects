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
        bool dui1 = Convert.ToBoolean(dui);             // Create boolean variable, converting from the string variable.

        Console.WriteLine("How many speeding tickets do you have?");    // Display the input request.
        string tickets = Console.ReadLine();            // Create variable to read the string input.
        int tickets1 = Convert.ToInt32(tickets);        // Create integer variable, converting from the string variable.

        bool qualified = (age1 > 15 && dui1 == false && tickets1 < 3);  // Boolean variable equals above 3 variables AND AND AND check.
        Console.WriteLine("Qualified: " + qualified);   // Display true or false, if qualified.


        Console.ReadLine();
    }
}


// TERNARY OPERATOR SAMPLE:
//int numVar1 = 100;
//int numVar2 = 10;
//string result = numVar1 > numVar2 ? "100 is greater than 10." : "100 is not greater than 10.";
//Console.WriteLine(result);


// BRANCHING VIDEO SAMPLES:
// ========================
//int roomTemp = 70;
//Console.WriteLine("Hi, what is your name?");
//string name = Console.ReadLine();

//Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
//int currentTemp = Convert.ToInt32(Console.ReadLine());

//if (currentTemp == roomTemp)
//{
//    Console.WriteLine("It is exactly room temperature.");
//}
//else if (currentTemp > roomTemp)
//{
//    Console.WriteLine("It is warmer than room temperature.");
//}
//else if (currentTemp < roomTemp)
//{
//    Console.WriteLine("It is colder than room temperature.");
//}
//else
//{
//    Console.WriteLine("Uhhhhh... something went wrong.");
//}


//int currentTemp = 80;
//int roomTemp = 70;
//string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
//Console.WriteLine(comparisonResult);

//if (currentTemp == roomTemp)
//{
//    Console.WriteLine("It is exactly room temperature.");
//}
//else if (currentTemp > roomTemp)
//{
//    Console.WriteLine("It is warmer than room temperature.");
//}
//else if (roomTemp > currentTemp)
//{
//    Console.WriteLine("Room temperature is warmer than the current temperature.");
//}
//else
//{
//    Console.WriteLine("It is not exactly room temperature.");
//}

