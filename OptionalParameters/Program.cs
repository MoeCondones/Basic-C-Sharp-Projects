using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalMeth newOpe = new OptionalMeth();
            Console.Write("Enter a number: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number (OPTIONAL) press enter to skip: ");
            try
            {
                int inp2 = Convert.ToInt32(Console.ReadLine());
                int res = newOpe.OpMeth(inp1, inp2);
                Console.WriteLine(inp1 + " X " + inp2 + " = " + res);
            }
            catch
            {
                int res = newOpe.OpMeth(inp1);
                Console.WriteLine(inp1 + " X 10 gives: " + res);
            }
            Console.ReadLine();
        }
    }
}
