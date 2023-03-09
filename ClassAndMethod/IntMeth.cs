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
        public int Operation (string str)
        {
            int numb = Convert.ToInt32(str);
            int result = numb / 2;
            return result;
        }
    }
}
