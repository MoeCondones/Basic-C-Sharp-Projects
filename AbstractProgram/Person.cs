using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lasName { get; set; }

        public abstract void sayName();
    }
}
