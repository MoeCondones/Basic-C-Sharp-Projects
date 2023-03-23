using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplyees = new List<Employee>()
            {
                new Employee {firstName = "Joe", lastName = "Adams", ID = 1 },
                new Employee {firstName = "Joe", lastName = "alex", ID = 1 },
                new Employee {firstName = "Joan", lastName = "Dale", ID = 1 },
                new Employee {firstName = "Joey", lastName = "fridman", ID = 1 },
                new Employee {firstName = "Jon", lastName = "winehouse", ID = 1 },
                new Employee {firstName = "Jona", lastName = "dave", ID = 1 },
                new Employee {firstName = "Jonah", lastName = "bane", ID = 1 },
                new Employee {firstName = "Jonny", lastName = "bones", ID = 1 },
                new Employee {firstName = "Jamon", lastName = "barns", ID = 1 },
                new Employee {firstName = "Jarred", lastName = "lavin", ID = 1 }
            };
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in emplyees)
            { 
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            Console.WriteLine("there is this many joes: " + joes);
            Console.ReadLine();
        }
        public class Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int ID { get; set; }
        }
    }
}
