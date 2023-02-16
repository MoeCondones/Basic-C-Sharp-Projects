using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymus Income Comparison Program");

            Console.WriteLine("persone 1");
            Console.WriteLine("hourly rate: ");
            double person1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours Worked per week: ");
            double person1HoursWorkedPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hoursly Rate: ");
            double person2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            double person2HoursWorkedPerWeek = Convert.ToDouble(Console.ReadLine());

            double person1AnnualSalary = person1HourlyRate * person1HoursWorkedPerWeek * 52;
            double person2AnnualSalary = person2HourlyRate * person1HoursWorkedPerWeek * 52;

            Console.WriteLine("Annual salary of person 1: " +person1AnnualSalary+" Dollars");
            Console.WriteLine("Annual salary of person 2: " +person2AnnualSalary+" Dollars");

            bool WhoMakesMore = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine("Does person 1 makes more than person 2? ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(WhoMakesMore);
            Console.ReadLine();
        }
    }
}
