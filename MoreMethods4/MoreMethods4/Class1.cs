using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods4
{
    static class Class1 
    {
        public static string staticstring = "This class cannot be inherited.";
        public static void StaticMethod()
        {
            Console.WriteLine("This method cannot be inherited.");
        }
    }
}
