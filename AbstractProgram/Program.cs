using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lasName = "Studnet";
            emp.sayName();

            IQuittable employee = new Employee();
            employee.Quit();

            Employee emp1 = new Employee();
            emp1.id = 1;
            Employee emp2 = new Employee();
            emp2.id = 2;

            Console.WriteLine(emp1 == emp2);
            Console.ReadLine();
        }
    }
}