using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods3
{
    class Operator
    {
        public Operator()
        {

        }

        public double Operate(double x, double y = 2)
        {
            x = Math.Pow(x, y);
            return x;
        }
    }
}
