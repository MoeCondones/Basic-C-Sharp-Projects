using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1


            string[] strings = { "adam", "jesse", "meave" };
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();

            for (int j = 0; j < strings.Length; j++)
            {
                strings[j] += " " + input;
            }

            foreach (string x in strings)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            //PART 2

            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i >= 1000)
                {
                    break;
                }
            }

            //PART 3

            for (int u = 0; u < 500;u++)
            {
                Console.WriteLine(u);
            }

            for (int x = 0; x <= 500; x++)
            {
                Console.WriteLine(x);
            }

            //PART 4

            List<string> strList = new List<string>();
            strList.Add("adam");
            strList.Add("homer");
            strList.Add("eve");

            bool found = false;
            while (!found)
            {
                Console.WriteLine("Enter text to search for in the list:");
                string search1 = Console.ReadLine();

                int index = 0;
                foreach (string name in strList)
                {
                    if (search1 == name)
                    {
                        Console.WriteLine("Your string matches the string at index: " + index);
                        found = true;
                        break;
                    }
                    index++;
                }
                if (!found)
                {
                    Console.WriteLine("your input is not found in the list");
                }
            }
            Console.ReadLine();

            //PART 5

            List<string> SameWord = new List<string>();
            SameWord.Add("hi");
            SameWord.Add("yo");
            SameWord.Add("bye");
            SameWord.Add("hi");
            SameWord.Add("new");

            Console.WriteLine("Enter text to search for in the list:");
            string search = Console.ReadLine();
            bool found1 = false;
            while (!found1)
            {
                for (int o = 0; o < SameWord.Count; o++)
                {
                    if (SameWord[o] == search)
                    {
                        Console.WriteLine("Your string matches the string at index: " + i);
                        found1 = true;
                    }
                }
                if (!found1)
                {
                    Console.WriteLine("your input was not found in the list");
                    search = Console.ReadLine();
                }
            }
            Console.ReadLine();

            //PART 6

            List<string> items = new List<string>();
            items.Add("box");
            items.Add("shovle");
            items.Add("saw");
            items.Add("box");
            List<string> duplicate = new List<string>();

            foreach (string s in items)
            {
                if (duplicate.Contains(s))
                {
                    Console.WriteLine(s+ " is duplicated here");
                }
                else
                {
                    duplicate.Add(s);
                    Console.WriteLine(s + " is not duplicated here");
                }
            }
            Console.ReadLine();
        }
    }
}
