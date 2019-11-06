using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] stringArray = {"Index 0", "Index 1", "Index 2", "Index 3", "Index 4" };
        int[] intArray = { 0, 1, 2, 3, 4 };

        Console.WriteLine("Select an index for stringArray[] (0-4):");
        int stringSelection = Convert.ToInt32(Console.ReadLine());
        if (stringSelection >= 0 && stringSelection < stringArray.Length) //if selected index is greater than 0 (first index value), and less than array length (5)
        {
            Console.WriteLine(stringArray[stringSelection]); //print index selected
        }
        else
        {
            Console.WriteLine("Incorrect choice."); //throw error
        }

        Console.WriteLine("Select an index for intArray[] (0-4):");
        int intSelection = Convert.ToInt32(Console.ReadLine());
        if (intSelection >= 0 && intSelection < intArray.Length)
        {
            Console.WriteLine(intArray[intSelection]);
        }
        else
        {
            Console.WriteLine("Incorrect choice.");
        }

        List<string> stringList = new List<string>(stringArray); //Create list by passing values from stringArray
        //stringList.Add("This is just an example for the instructor")
        int listLength = stringList.Count;
        Console.WriteLine("Select an index for stringList[] (0-4):");
        int indexSelection = Convert.ToInt32(Console.ReadLine());
        if (indexSelection >= 0 && indexSelection < listLength)
        {
            Console.WriteLine(stringList[indexSelection]);
        }
        else
        {
            Console.WriteLine("Incorrect choice.");
        }

        Console.Read();

    }
}