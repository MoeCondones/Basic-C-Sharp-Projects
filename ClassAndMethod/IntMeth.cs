using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class IntMeth
    {
        public int Operation(int number)
        {
            int result = number * 5;
            return result;
        }
        public decimal Operation (decimal num)
        {
            decimal result = num + 4.32m;
            return result;
        }
        public string Operation (string str)
        {
            int str = Convert.ToInt32();
            int result = str / 2;
            return result;
        }
    }
}
