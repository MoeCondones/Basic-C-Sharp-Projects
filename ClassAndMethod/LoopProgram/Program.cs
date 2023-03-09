using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("guess a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool guess = num == 25;

            while (!guess)
            {
                switch (num)
                {
                    case 25:
                        Console.WriteLine("this is the correct number!!");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("sorry, the number was incorrect. please try again");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("guess another number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessed = number == 30;

            do
            {
                switch (number)
                {
                    case 30:
                        Console.WriteLine("you guessed the right number!!!");
                        guessed = true;
                        break;

                    default:
                        Console.WriteLine("sorry, the number was incorrect, please try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessed);
            Console.ReadLine();
        }
    }
}
