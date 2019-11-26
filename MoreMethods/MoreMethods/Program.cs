using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Multiply(5, 6);
            math.Multiply(x: 10, y: 12);
            Console.ReadLine();
        }
    }
}
