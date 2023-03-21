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
            Employee<string> emp = new Employee<string>();
            emp.firstName = "Sample";
            emp.lasName = "Studnet";
            emp.sayName();

            IQuittable employee = new Employee<int>();
            employee.Quit();

            Employee<int> emp1 = new Employee<int>();
            emp1.Id = 1;
            Employee<int> emp2 = new Employee<int>();
            emp2.Id = 2;

            Console.WriteLine(emp1 == emp2);


            Console.ReadLine();
        }
    }
}
