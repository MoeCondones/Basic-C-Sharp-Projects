using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                weekDays inp = (weekDays)Convert.ToInt32(Console.ReadLine());


            }
            catch
            {
                Console.WriteLine("please enter an actual day of the week!");
                Console.ReadLine();
            }
        }
        public enum weekDays
        {
            mondays,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
