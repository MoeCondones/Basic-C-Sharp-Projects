using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass answer = new VoidClass();
            Console.Write("Enter a number that will be divided by 2: ");
            int inp = Convert.ToInt32(Console.ReadLine());
            answer.voidnum(inp);

            int output;
            answer.OutputMeth(10, out output);
            Console.WriteLine("the result of the operation is: " + output);

            string result;
            answer.OutputMeth("There", out result);
            Console.ReadLine();
        }
    }
}
