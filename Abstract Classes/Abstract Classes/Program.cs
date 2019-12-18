using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Id = 1234
            };
            Employee employee2 = new Employee
            {
                Id = 1234
            };
            if (employee1 == employee2)
                Console.WriteLine("Employee1 and Employee2 have the same Id.");
            else
                Console.WriteLine("Employee1 and Employee2 do not have the same Id.");
            Console.ReadLine();

            //IQuittable quittable = new Employee();
            //quittable.Quit();
        }
    }
}
