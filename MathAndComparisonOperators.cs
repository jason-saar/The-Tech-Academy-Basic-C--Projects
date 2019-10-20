using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
      

            Console.WriteLine("Enter a number:");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            int answerOne = inputOne * 50;
            Console.WriteLine(inputOne + " multiplied by 50 = " + answerOne);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            int answerTwo = inputTwo + 25;
            Console.WriteLine(inputTwo + " + 25 = " + answerTwo);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            float inputThree = Convert.ToSingle(Console.ReadLine());
            float answerThree = inputThree / 25;
            Console.WriteLine(inputThree + " divided by 12.5 = " + answerThree);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int inputFour = Convert.ToInt32(Console.ReadLine());
            bool answerFour = inputFour > 50;
            Console.WriteLine(inputFour + " > 50 = " + answerFour);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int inputFive = Convert.ToInt32(Console.ReadLine());
            int answerFive = inputFive % 7;
            Console.WriteLine("Remainder of: " + answerFive);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


        }
    }
}
