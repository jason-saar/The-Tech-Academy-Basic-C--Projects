using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();
            string day;

            Console.WriteLine("Enter the current day of the week.");
            day = Console.ReadLine();
            day = days.UppercaseFirst(day);

            days.Parse(day);

            Console.Read();
            


        } 
    }
}
