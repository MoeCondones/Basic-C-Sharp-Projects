using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class OptionalMeth
    {
        public int OpMeth (int num1, int num2 = 0)
        {
            int result = num1 * 10;
            if (num2 != 0)
            {
                result = num2 * 2;
            }
            return result;
        }
    }
}
