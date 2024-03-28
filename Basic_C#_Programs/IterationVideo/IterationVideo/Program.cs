using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
// CREATE a list, foreach on score in the testScores list, then if a score is above 85 generate a count of the passingScore values:
        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine("There were " + passingScores.Count + " passing scores.");


        Console.ReadLine();
    }
}




// *********STRING ITERATION (entire array/cleaner- advantage of list over an array):
//List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };
// PRINT All names in the array to the console:
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
//Console.ReadLine();


// STRING ITERATION (foreach loop/create list/if score greater than 85):
//List<int> testScores = new List<int>();
//testScores.Add(98);
//testScores.Add(99);
//testScores.Add(81);
//testScores.Add(72);
//testScores.Add(70);

//foreach (int score in testScores)
//{
//    if (score > 85)
//    {
//        Console.WriteLine("Passing test score: " + score);
//    }
//}


// STRING ITERATION (if/then):
//string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
//for (int j = 0; j < names.Length; j++)
//{
// PRINT to the console any names in the array equal to "Jesse":
//    if (names[j] == "Jesse")
//    {
//        Console.WriteLine(names[j]);
//    }
//}


// STRING ITERATION (entire array):
//string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
// PRINT All names in the array to the console:
//for (int j = 0; j < names.Length; j++)
//{
//    Console.WriteLine(names[j]);
//}


// INT ITERATION:
//int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
//for (int i = 0; i < testScores.Length; i++)
//{
//    if (testScores[i] > 85)
//    {
//        Console.WriteLine("Passing Test Score: " + testScores[i]);
//    }
//}
