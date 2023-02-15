using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            string Input = Console.ReadLine();
            decimal number = Convert.ToDecimal(Input);
            decimal result = number * 50;

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("enter a number that will be added by 25: ");
            string addent = Console.ReadLine();
            int adder = int.Parse(addent);
            int answer = adder + 25;

            Console.WriteLine(answer);
            Console.ReadLine();

            Console.WriteLine("enter a number that will be devided by 12.5: ");
            double devider = Convert.ToDouble(Console.ReadLine());
            double devident = devider / 12.5;

            Console.WriteLine(devident);
            Console.ReadLine();

            Console.WriteLine("type a random number: ");
            int numbers = Convert.ToInt32(Console.ReadLine());

            bool results = number > 50;
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("tupe a random number: ");
            int NumberInput = Convert.ToInt32(Console.ReadLine());

            int Remainder = NumberInput % 7;
            Console.WriteLine(Remainder);
            Console.ReadLine();
        }
    }
}
