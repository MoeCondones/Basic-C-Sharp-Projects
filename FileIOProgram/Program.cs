﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Delegate\Desktop\text.txt", input);
            string output = File.ReadAllText(@"C:\Users\Delegate\Desktop\text.txt");
            Console.WriteLine("the number you entered is {0}", output);

            Console.WriteLine("The current date and time is " + DateTime.Now);
            Console.Write("enter a number:");
            int inp = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime = DateTime.Now.AddHours(inp);
            Console.WriteLine("in " + inp + " hours the time will be " + dateTime);

            const int number = 2000;
            var str = "first var";
            
            Chainedcstruct chainedcstruct = new Chainedcstruct();
            chainedcstruct.myMeth("adam", 20);

            Console.ReadLine();
        }
        public class Chainedcstruct
        {
            public Chainedcstruct(): this(10)
            {

            }
            public Chainedcstruct(int Age)
            {

            }
            public void myMeth(string name, int age)
            {
                Console.WriteLine("name: "+name+ ", Age:"+age);
            }
        }
    }
}
