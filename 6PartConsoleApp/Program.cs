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


            //string[] strings = { "adam", "jesse", "meave" };
            //Console.Write("Enter some text: ");
            //string input = Console.ReadLine();

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    strings[i] += " " + input;
            //}

            //foreach (string x in strings)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadLine();

            //PART 2

            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i >= 1000)
            //    {
            //        break;
            //    }
            //}

            //PART 3

            //for (int i = 0; i < 500; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int x = 0; x <= 500; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //PART 4

            //List<string> strList = new List<string>();
            //strList.Add("adam");
            //strList.Add("homer");
            //strList.Add("eve");

            //bool found = false;
            //while (!found)
            //{
            //    Console.WriteLine("Enter text to search for in the list:");
            //    string search = Console.ReadLine();

            //    int index = 0;
            //    foreach (string name in strList)
            //    {
            //        if (search == name)
            //        {
            //            Console.WriteLine("Your string matches the string at index: " + index);
            //            found = true;
            //            break;
            //        }
            //        index++;
            //    }
            //    if (!found)
            //    {
            //        Console.WriteLine("your input is not found in the list");
            //    }
            //}
            //Console.ReadLine();

            //PART 5

            List<string> SameWord = new List<string>();
            SameWord.Add("hi");
            SameWord.Add("yo");
            SameWord.Add("bye");
            SameWord.Add("hi");
            SameWord.Add("new");

            Console.WriteLine("Enter text to search for in the list:");
            string search = Console.ReadLine();
            bool found = false;
            while (!found)
            {
                for (int i = 0; i < SameWord.Count; i++)
                {
                    if (SameWord[i] == search)
                    {
                        Console.WriteLine("Your string matches the string at index: " + i);
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Your input was not found in the list.");
            }

            Console.ReadLine();

            //PART 6

            
        }
    }
}
