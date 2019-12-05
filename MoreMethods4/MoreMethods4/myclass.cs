using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods4
{
    class myclass
    {
        public void Test(int i, out int j)
        {
            j = i / 2;
        }

        public void Test(int i, out int j, out int z)
        {
            j = i / 2;
            z = i / 4;
        }
    }
}
