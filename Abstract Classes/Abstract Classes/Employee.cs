using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class Employee : Person, IQuittable

    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee name: ");
            base.SayName();
        }

        public void Quit()
        {
            Environment.Exit(0);
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            Employee employee = obj as Employee;

            return !Object.ReferenceEquals(null, employee)
                && Int32.Equals(Id, employee.Id);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;
                hash = (hash * 7) + (!Object.ReferenceEquals(null, Id) ? Id.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
