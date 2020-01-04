using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Days
    {
        public Day Day { get; set; }

        public string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        public void Parse(string d)
        {
            try
            {
                Day day = (Day)Enum.Parse(typeof(Day), d);
                Console.WriteLine("It is " + day);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
    }
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
