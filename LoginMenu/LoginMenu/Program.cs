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
            string admin = "root";
            string adminPass = "toor";
            bool isAuthorized = false;
            bool isUser = false;
            int tries = 0;
            do
            {
                while (!isUser)
                {
                    Console.WriteLine("Enter Username: ");
                    string user = Console.ReadLine();
                    if (user == admin)
                    {
                        isUser = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Username. Try Again.");
                    }
                }
                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();
                if (password == adminPass)
                {
                    isAuthorized = true;
                }
                else
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
