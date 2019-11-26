using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator op = new Operator();
            double x;
            string y;
            Console.WriteLine("Enter the first number: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number (optional): ");
            y = Console.ReadLine();
            if (!string.IsNullOrEmpty(y))
            {
                Console.WriteLine(op.Operate(x, Convert.ToDouble(y)));
            } else
            {
                Console.WriteLine(op.Operate(x));
            }
            Console.ReadLine();
        }
    }
}
