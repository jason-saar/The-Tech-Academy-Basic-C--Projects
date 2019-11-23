using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Add(i));
            Console.WriteLine(Math.Subtract(i));
            Console.WriteLine(Math.Multiply(i));
            Console.ReadLine();
        }
    }
}
