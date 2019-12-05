using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods4
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            Console.WriteLine("Input a number:");
            int i = Convert.ToInt32(Console.ReadLine());
            myclass.Test(i, out int j);
            Console.WriteLine("Your input divided by 2 is {0}", j);
            Console.WriteLine("Input a number:");
            i = Convert.ToInt32(Console.ReadLine());
            myclass.Test(i, out j, out int z);
            Console.WriteLine("Your input divided by 2 is {0}, divided by 4 is {1}", j, z);
            Console.ReadLine();
        }
    }
}
