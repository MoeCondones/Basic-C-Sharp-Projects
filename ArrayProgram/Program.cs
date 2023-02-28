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
            Console.WriteLine("pick a number between 0 and 2");
            string[] stringarray = new[] { "pikachu", "evee", "snorlax", };

            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 2)
            {
                Console.WriteLine("this index does not exist. please pick a number between 0 and 2");
            }

            Console.WriteLine("you got " + stringarray[num]);

            Console.WriteLine("enter an index between 0 and 6 to get a special number: ");
            int[] intArray = { 5, 123, 234, 324, 13432, 132, 432 };

            int index = Convert.ToInt32(Console.ReadLine());
            if (index > 6)
            {
                Console.WriteLine("this index does not exist. please pick a number between 0 and 6");
            }

            Console.WriteLine("you got the special number: " + intArray[index]);

            Console.WriteLine("pick a number between 0 and 2 to get a special string: ");
            List<string> stringlist = new List<string>();
            stringlist.Add("hello");
            stringlist.Add("world");
            stringlist.Add("aliens");


            int result = Convert.ToInt32(Console.ReadLine());
            if (result > 2)
            {
                Console.WriteLine("this index does not exist. please pick a number between 0 and 2");
            }

            Console.WriteLine("you got the string: " + stringlist[result]);
            Console.ReadLine(); 
        }
    }
}
