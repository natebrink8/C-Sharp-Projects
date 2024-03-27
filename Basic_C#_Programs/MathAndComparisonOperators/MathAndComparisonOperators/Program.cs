using System;

class Program
{
    static void Main(string[] args)
    {
        // MATH OPERATORS/////////////////////////////////////////////////
        //int total = 5 + 10;
        //int otherTotal = 12 + 22;
        //int combined = total + otherTotal;
        //Console.WriteLine(combined);
        //Console.ReadLine();

        //int difference = 10 - 5;
        //Console.WriteLine("Ten minus five = " + difference.ToString());
        //Console.ReadLine();

        //int product = 10 * 5;
        //Console.WriteLine(product);
        //Console.ReadLine();

        //double quotient = 100.0 / 17.0;
        //Console.WriteLine(quotient);
        //Console.ReadLine();

        //int remainder = 11 % 2;
        //Console.WriteLine(remainder);
        //Console.ReadLine();


        // COMPARISON OPERATORS ///////////////////////////////////////////
        // true or false
        //bool trueOrFalse = 12 < 5;
        //Console.Write(trueOrFalse.ToString());
        //Console.ReadLine();

        int roomTemp = 70;
        int currentTemp = 70;
        // bool isWarm = currentTemp >= roomTemp;
        bool isWarm = currentTemp != roomTemp;
        Console.WriteLine(isWarm);
        Console.ReadLine();

    }
}