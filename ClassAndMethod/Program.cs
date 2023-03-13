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

            Console.WriteLine("Multiplying " + input + " By 5 Gives " + result);

            Console.Write("Enter a new number: ");
            decimal input1 = decimal.Parse(Console.ReadLine());

            decimal result1 = mathOpe.Operation(input1);
            Console.WriteLine("Adding 4.32 to " + input1 + " gives " + result1);

            Console.Write("Enter a new number that will be divided: ");
            string input2 = Console.ReadLine();

            int result2 = mathOpe.Operation(input2);
            Console.WriteLine("Dividing " + input2 + " by 2 gives " + result2);

            Console.ReadLine();
        }
    }
}
