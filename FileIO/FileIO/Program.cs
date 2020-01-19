using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Jason\Documents\log.txt", num);                // Write text to .txt file in directory
            string text = File.ReadAllText(@"C:\Users\Jason\Documents\log.txt");        // Read .txt file and assign all text to the string text
            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}
