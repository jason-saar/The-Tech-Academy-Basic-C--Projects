using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee()
                {
                    FirstName="Zofia",
                    LastName="Tison",
                    Id=1
                },
                new Employee()
                {
                    FirstName="Lourdes",
                    LastName="Cortright",
                    Id=2
                },
                new Employee()
                {
                    FirstName="Kyle",
                    LastName="Gaskins",
                    Id=3
                },
                new Employee()
                {
                    FirstName="Micaela",
                    LastName="Casella",
                    Id=4
                },
                new Employee()
                {
                    FirstName="Joe",
                    LastName="Demo",
                    Id=5
                },
                new Employee()
                {
                    FirstName="Latia",
                    LastName="Fray",
                    Id=6
                },
                new Employee()
                {
                    FirstName="Ofelia",
                    LastName="Hackman",
                    Id=7
                },
                new Employee()
                {
                    FirstName="Joe",
                    LastName="Bequette",
                    Id=8
                },
                new Employee()
                {
                    FirstName="Eliz",
                    LastName="Fimbres",
                    Id=9
                },
                new Employee()
                {
                    FirstName="Evelyn",
                    LastName="Ocegueda",
                    Id=10
                }
            };


            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> lambdaJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> employees1 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in lambdaJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " Id: " + employee.Id);
            }

            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " Id: " + employee.Id);
            }

            foreach (Employee employee in employees1)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " Id: " + employee.Id);
            }

            Console.ReadLine();

        }
    }
}
