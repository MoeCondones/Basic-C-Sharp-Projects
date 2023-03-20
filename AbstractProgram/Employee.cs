using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine("My name is " + firstName + " " + lasName);
        }
    }
}
