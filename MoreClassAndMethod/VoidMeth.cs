using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassAndMethods
{
    public class VoidClass
    {
        public void voidnum(int num)
        {
            int result = num / 2;
            Console.WriteLine("the result is " + result);
        }

        public void OutputMeth(int num, out int number)
        {
            number = num * 2;
        }
        
        
    }
    public static class VoidString
        {
            public static void OutputMeth(string str)
                {
                    Console.WriteLine(str);
                }
        }
}
