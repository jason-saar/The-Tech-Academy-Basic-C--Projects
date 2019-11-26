using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.WriteLine(operation.Operate(10));
            Console.WriteLine(operation.Operate(1.6M));
            Console.WriteLine(operation.Operate("5"));
            Console.ReadLine();
        }
    }
}
