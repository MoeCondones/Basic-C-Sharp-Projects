using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Program
    {
        static void Main()
        {
            string[] stringarray = new[] { "pikachu", "evee", "snorlax", };
            Console.WriteLine("pick a number between 0 and 2");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you got " + stringarray[num]);
            Console.ReadLine();

            int[] intArray = { 5, 123, 234, 324, 13432, 132, 432 };
            Console.WriteLine("enter an index between 0 and 6 to get a special number: ");

            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you got the special number: " + intArray[index]);
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("world");
            stringList.Add("Aliens");

            Console.WriteLine("pick a number between 0 and 2 to get a special string: ");
            int result = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you got the string: " + stringList[result]);
            Console.ReadLine();
        }
    }
}
