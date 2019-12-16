using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class Employee : Person, IQuittable

    {
        public override void SayName()
        {
            Console.WriteLine("Employee name: ");
            base.SayName();
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
