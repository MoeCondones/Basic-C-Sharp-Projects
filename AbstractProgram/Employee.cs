using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }
        public string name { get; set; }
        public override void sayName()
        {
            Console.WriteLine("My name is " + firstName + " " + lasName);
        }
        public void Quit()
        {
            Console.WriteLine($" {firstName} {lasName} is quitting the job");
        }
        public static bool operator ==(Employee emp, Employee emp1)
        {
            return emp.id == emp1.id; 
        }
        public static bool operator !=(Employee emp, Employee emp1)
        {
            return !(emp == emp1);
        }
    }
}