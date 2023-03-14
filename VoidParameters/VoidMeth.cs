using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidParameters
{
    class VoidMeth
    {
        public void voidMeth (int num1, int num2)
        {
            int result = num1 + 50;

            Console.WriteLine("resule of the operation: " + result);
            Console.WriteLine("the value of num2 is: " + num2); 
        }
    }
}
