using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string admin = "root";          //Admin Username
            string adminPass = "toor";      //Admin Password
            bool isAuthorized = false;      //Password Comparison bool
            bool isUser = false;            //Username Comparison bool
            int tries = 0;                  //Login Attempts
            do //Password loop, 5 attempts, requires username loop to be broken first.
            {
                while (!isUser) //Username Login Loop requires "root" to end loop
                {
                    Console.WriteLine("Enter Username: ");
                    string user = Console.ReadLine();
                    if (user == admin) //Correct uusername
                    {
                        isUser = true;
                    }
                    else //Unlimited username attempts
                    {
                        Console.WriteLine("Incorrect Username. Try Again.");
                    }
                }
                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();
                if (password == adminPass) //password correct, set bool to true, break loop
                {
                    isAuthorized = true;
                }
                else //incorrect password, increment tries, tries >= 5 exit program
                {
                    tries += 1; 
                    if (tries >= 5)
                    {
                        Console.WriteLine("Too many failed attempts. Exiting Program.");
                        Console.Read();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Incorrect Password. Try Again. Failed Attempts: " + tries);
                }

            }
            while (!isAuthorized);
            Console.Write("Login Successful");
            Console.Read();
        }
    }
}
