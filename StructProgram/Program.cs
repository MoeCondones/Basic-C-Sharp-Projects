using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Number number2 = number;
            number2.Amount = 433m / 234m;

            Console.WriteLine("the divided amount is: " + number2.Amount);
            Console.ReadLine();

        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
