using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Sample
    {
        public int? _age;                               //Nullable int, if age is not passed through in constrcutor
        public string _name;                            

        public Sample(string name) : this(name, null)   //Constructor taking one arguement, pass arguement to next constructor, and also pass null for int age
        {

        }

        public Sample(string name, int? age)            //Constructor taking two arguements, assign variables passed to class variables
        {
            _age = age;
            _name = name;
        }
    }
}
