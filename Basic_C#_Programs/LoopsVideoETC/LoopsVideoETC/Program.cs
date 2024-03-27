﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a number.");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 12;

        do
        {
            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again.");
                    Console.WriteLine("Guess a number.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 29:
                    Console.WriteLine("You guessed 29. Try again.");
                    Console.WriteLine("Guess a number.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 12:
                    Console.WriteLine("You guessed 12, that is correct!");
                    isGuessed = true;
                    break;
                default:
                    Console.WriteLine("You are wrong.");
                    Console.WriteLine("Guess a number.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!isGuessed);

        Console.ReadLine();
    }
}





// LOOP code for While/Do
// //////////////////////
//Console.WriteLine("Guess a number.");
//int number = Convert.ToInt32(Console.ReadLine());
//bool isGuessed = number == 12;

//do
//{
//    switch (number)
//    {
//        case 62:
//            Console.WriteLine("You guessed 62. Try again.");
//            Console.WriteLine("Guess a number.");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 29:
//            Console.WriteLine("You guessed 29. Try again.");
//            Console.WriteLine("Guess a number.");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 55:
//            Console.WriteLine("You guessed 55. Try again.");
//            Console.WriteLine("Guess a number.");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//        case 12:
//            Console.WriteLine("You guessed 12, that is correct!");
//            isGuessed = true;
//            break;
//        default:
//            Console.WriteLine("You are wrong.");
//            Console.WriteLine("Guess a number.");
//            number = Convert.ToInt32(Console.ReadLine());
//            break;
//    }
//}
//while (!isGuessed);

//Console.ReadLine();
