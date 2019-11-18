using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        try
        {
            List<int> integers = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };        //List of random integers
            Console.WriteLine("Enter a number.");
            float divisor = (float) Convert.ToDouble(Console.ReadLine());                       //Explicitly type cast Double as float and assign to divisor
            foreach (int dividend in integers)                                                  //Foreach loop through using dividend as index value in list integers
            {
                float result = dividend / divisor;                                              //Calculate dividend/divisor and assign answer to result
                Console.WriteLine(dividend + " / " + divisor + " = " + result);                 //Print equation.
            }
        }
        catch (FormatException)                                                                 //Catch format exception ex. string, throw error.
        {
            Console.WriteLine("Please type a whole number.");
        }
        catch (DivideByZeroException)                                                           //Catch division by zero, throw error.
        {
            Console.WriteLine("You cannot divide by zero.");
        }
        finally                                                                                 //End of try/catch block, pause.
        {
            Console.ReadLine();
        }
        Console.WriteLine("The program has emerged from a try/catch block");                   //Anounce emergence from block.
        Console.ReadLine();

    }
}

