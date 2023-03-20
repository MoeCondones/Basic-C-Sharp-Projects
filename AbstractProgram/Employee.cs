using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("My name is " + firstName + " " + lasName);
        }
        public void Quit()
        {
            Console.WriteLine($" {firstName} {lasName} is quitting the job");
        }
    }
}