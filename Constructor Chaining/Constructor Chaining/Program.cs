using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const string author = "Jason Saar";                         //Constant String
            var age = 26;                                               //Declared int using var

            var sample = new Sample(author);                            //initialize class using one arguement
            Console.WriteLine("{0} {1}", sample._name, sample._age);    //print class variables which have been assigned using constructor chaining
            var sample2 = new Sample(author, age);                      //initialize class using two arguements
            Console.WriteLine("{0} {1}", sample2._name, sample2._age);  //print class variables which have been assigned using constructor taking two arguements
            Console.Read();
        }
    }
}
