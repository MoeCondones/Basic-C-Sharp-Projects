using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("have you ever had a DUI violation (yes/no)");
            string dui = Console.ReadLine();
            bool hasDUI = false;
            if (dui == "yes")
            {
                hasDUI = true;
            }

            Console.WriteLine("how many speeding tickets have you had? ");
            int SpeedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualifies = age > 15 && !hasDUI && SpeedingTickets <= 3;
            Console.WriteLine("qualifies for car insurance: " + qualifies);
            Console.ReadLine();
        }
    }
}
