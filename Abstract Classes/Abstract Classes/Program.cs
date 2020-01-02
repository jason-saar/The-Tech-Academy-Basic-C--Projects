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
            Employee<string> employee1 = new Employee<string>
            {
                Things = new List<string> { "Thing 1", "Thing 2", "Thing 3", "Thing 4" }
            };

            Employee<int> employee2 = new Employee<int>
            {
                Things = new List<int> { 1, 2, 3, 4 }
            };

            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

            //Employee employee1 = new Employee
            //{
            //    Id = 1234
            //};
            //Employee employee2 = new Employee
            //{
            //    Id = 1234
            //};
            //if (employee1 == employee2)
            //    Console.WriteLine("Employee1 and Employee2 have the same Id.");
            //else
            //    Console.WriteLine("Employee1 and Employee2 do not have the same Id.");
            //Console.ReadLine();

            //IQuittable quittable = new Employee();
            //quittable.Quit();


        }
    }
}
