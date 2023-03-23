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
                new Employee {firstName = "Joe", lastName = "alex", ID = 2 },
                new Employee {firstName = "Joan", lastName = "Dale", ID = 3 },
                new Employee {firstName = "Joey", lastName = "fridman", ID = 4 },
                new Employee {firstName = "Jon", lastName = "winehouse", ID = 5 },
                new Employee {firstName = "Jona", lastName = "dave", ID = 6 },
                new Employee {firstName = "Jonah", lastName = "bane", ID = 7 },
                new Employee {firstName = "Jonny", lastName = "bones", ID = 8 },
                new Employee {firstName = "Jamon", lastName = "barns", ID = 9 },
                new Employee {firstName = "Jarred", lastName = "lavin", ID = 10 }
            };
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in emplyees)
            { 
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> joes1 = emplyees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee joe in joes1)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " " + joe.ID);
            }

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
