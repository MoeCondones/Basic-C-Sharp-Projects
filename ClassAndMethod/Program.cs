using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            IntMeth mathOpe = new IntMeth();
            int result = mathOpe.Operation(input);

            Console.WriteLine("Adding 5 to " + input + " gives " + result);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            decimal input1 = decimal.Parse(Console.ReadLine());

            int decResult = IntMeth.Operation(input1);
            Console.WriteLine("the result of the decimal operation:" +decResult);
            
            Console.ReadLine();
        }
    }
}
