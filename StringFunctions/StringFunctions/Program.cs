using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string firstName = "Jason";
            string middleName = "Samuel";
            string LastName = "Saar";
            string name = firstName + " " + middleName + " " + LastName;
            Console.WriteLine(name);

            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jason.");
            sb.Append(" I live in Portland, Oregon.");
            sb.Append(" I am 26 years old, and I attend The Tech Academy.");
            sb.Append(" This is a StringBuilder demo.");
            Console.Write(sb);

            Console.ReadLine();

        }
    }
}
