using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Today;                                                          
            int birthYear = 0;                                                                      
            int age = 0;
            string answer = "";
            try
            {
                while (age <= 0)
                {
                    Console.WriteLine("What's your age?");
                    try
                    {
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age <= 0)
                        {
                            throw new ArgumentOutOfRangeException();                                     
                        }
                    }
                    catch (ArgumentOutOfRangeException)                                                   
                    {
                        Console.WriteLine("Error, age must be positive and greater than 0");
                        age = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error, age must be positive and greater than 0");
                        age = 0;
                    }
                }
                while (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Have you had a birthday yes this year? (Y/N)");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        birthYear = dt.Year - age;
                    }
                    else if (answer == "n")
                    {
                        birthYear = dt.Year - age;
                        birthYear -= 1;
                    }
                    if (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Incorrect answer. Please enter Y or N");
                        answer = "";
                    }
                }
                Console.WriteLine("You were born in {0}", birthYear);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured, contact your System Administrator.");
            }
            Console.ReadLine();
        }
    }
}
