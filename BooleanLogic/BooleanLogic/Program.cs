using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());     
            Console.WriteLine("Have you ever had DUI? (Y/N)");  
            string duiAnswer = Console.ReadLine();
            bool? dui = null;                                   //initialize nullable bool
            if (duiAnswer.ToLower() == "y")                     //ToLower() compare
            {
                dui = true;                                     //assign bool
            }
            else if (duiAnswer.ToLower() == "n")                //ToLower() compare
            {
                dui = false;                                    //assign bool
            }
            else
            {
                Console.WriteLine("Incorrect Answer");          //output error
            }
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool? qualified = null;
            if (age > 15 && dui == false  && tickets < 4)       //boolean logic
            {
                qualified = true;
            } else
            {
                qualified = false;
            }
            Console.WriteLine("Qualified?");
            Console.WriteLine(Convert.ToString(qualified));

            Console.ReadLine();


        }
    }
}
