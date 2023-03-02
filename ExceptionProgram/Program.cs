using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> num = new List<int>();
                num.Add(3);
                num.Add(5);
                num.Add(4);
                num.Add(1);

                Console.WriteLine("enter a number to divide each number in the list by: ");
                int input = int.Parse(Console.ReadLine());

                foreach (int n in num)
                {
                    int result = n / input;
                    Console.WriteLine(n + " divided by " +input+ " is " +result);
                }
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException en)
            {
                Console.WriteLine(en.Message);
            }
            Console.ReadLine();
        }
    }
}
