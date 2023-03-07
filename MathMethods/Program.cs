using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass mathOpe = new mathClass();

            Console.WriteLine("Enter a number to perform a math operation on: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int addNum = mathOpe.addTen(input);
            int subNum = mathOpe.subTen(input);
            int multNum = mathOpe.multiFive(input);

            Console.WriteLine("Adding 10 to" + input + " gives " + addNum);
            Console.WriteLine("Subtracting 10 from " + input + " gives " +subNum);
            Console.WriteLine("Multiplying " + input + " by " +input+ " gives " + multNum);
            Console.ReadLine();
        }
    }
}
