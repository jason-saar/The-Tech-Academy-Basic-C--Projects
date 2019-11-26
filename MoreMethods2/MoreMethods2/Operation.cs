using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods2
{
    class Operation
    {
        public Operation()
        {

        }
        public int Operate(int x)
        {
            x = ++x;
            return x;
        }

        public int Operate(double x)
        {
            x = Math.Floor(x);
            x = --x;
            return Convert.ToInt32(x);
        }

        public int Operate(string s)
        {
            int x;
            Int32.TryParse(s, out x);
            x = x + 2;
            return x;
        }
    }
}
