using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                
                var age = Convert.ToInt32(Console.ReadLine());

                if(age <= 0)
                {
                    throw new Exception("You cant enter "+age+ " as a age");
                }

                int birthyear = DateTime.Now.Year - age;
                Console.WriteLine("you were born in " + birthyear);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
                Console.ReadLine();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
