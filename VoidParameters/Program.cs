using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMeth method = new VoidMeth();

            method.voidMeth(4, 20);

            method.voidMeth(num1: 20, num2: 10);
            Console.ReadLine();

        }
    }
}
