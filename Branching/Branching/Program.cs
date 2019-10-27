using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
                                                                                                            //Package Weight Check
            Console.WriteLine("Enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
                                                                                                          //Package Dimensions Check
            Console.WriteLine("Enter package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int sum = length + width + height;
            if (sum > 50 )
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
                                                                                                        //Package Quote
            float quote = sum * weight / 100;
            Console.WriteLine("Quoted price: $" + quote);
            Console.ReadLine();

        }
    }
}
