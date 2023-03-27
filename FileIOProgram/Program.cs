using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Delegate\Desktop\text.txt", input);
            string output = File.ReadAllText(@"C:\Users\Delegate\Desktop\text.txt");
            Console.WriteLine("the number you entered is {0}", output);
            Console.ReadLine();
        }
    }
}
