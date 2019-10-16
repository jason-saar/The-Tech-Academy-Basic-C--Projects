using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favoreite number is " + favoriteNumber + ".");
            //Console.WriteLine("Your favorite number + 5 is: " + total + ".");
            //Console.ReadLine();

            //bool isStudying = true;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("---------------------");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            bool needHelp = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();


        }
    }
}
