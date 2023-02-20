using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuotesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PAckage Express. Please follow the instructions below");
            Console.WriteLine("enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimensions = width + height + length;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    int AllTogether = width * height * length / 100;
                    Console.WriteLine("the Price of shipping will be: " + AllTogether + "£");
                }
                Console.ReadLine();
            }
            
            
        }
    }
}
