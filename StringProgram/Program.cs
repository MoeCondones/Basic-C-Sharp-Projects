using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{
    class Program
    {
        static void Main()
        {
            string name = "Mohamed";
            int age = 21;
            string city = "glasgow";

            string concat = "hey my name is " + name + " and im " + age + ", i live in " + city;
            string upper = concat.ToUpper();
            Console.WriteLine(upper);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("this is the stringBuilder assignment");
            sb.Append(" This is the c# string part of the course");
            sb.Append(" The sky was painted in shades of orange and pink");
            sb.Append(" the painting was as bright as the sun");

            string paragraph = sb.ToString();
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
