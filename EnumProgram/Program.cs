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
                string inp = Console.ReadLine();
                WeekDays days = (WeekDays)Enum.Parse(typeof(WeekDays), inp);

                Console.WriteLine("the current day is " + inp);
                Console.ReadLine();

            }
            catch(Exception)
            {
                Console.WriteLine("please enter an actual day of the week!");
                Console.ReadLine();
            }
        }
        public enum WeekDays
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
