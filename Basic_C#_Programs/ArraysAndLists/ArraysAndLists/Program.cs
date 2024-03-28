using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Nate");
        intList.Remove("Nate");

        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}



// SAMPLE OF SETTING A BYtE ARRAY:      byte[] byteArray = new byte[5000];


// YOUR KISS IS ON MY LIST
//List<int> intList = new List<int>();
//intList.Add(4);
//intList.Add(10);
//intList.Remove(10);
//Console.WriteLine(intList[0]);
//Console.ReadLine();


// GIVE ME ARRAYS!
//int[] numArray = new int[5];
//numArray[0] = 5;
//numArray[1] = 2;
//numArray[2] = 10;
//numArray[3] = 200;
//numArray[4] = 5000;

//int[] numArray1 = new[] { 5, 2, 10, 200, 5000 };

//int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

//numArray2[5] = 650;

//Console.WriteLine(numArray2[3]);
//Console.ReadLine();