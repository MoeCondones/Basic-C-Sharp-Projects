using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    public class OptionalMeth
    {
        public int OpMeth (int num, int number = 0)
        {
            int result = num * 10;
            if (number != 0)
            {
                int res = number * 2;
            }
            return result;
        }
    }
}
