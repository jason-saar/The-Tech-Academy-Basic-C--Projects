using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number
            {
                Amount = 3.14M
            };
            Console.WriteLine(num.Amount);
            Console.Read();
        }
    }
}
