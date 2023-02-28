using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 89, 94, 93, 1, 43, 13, 53, 65, 13, 87, 32 };

            //for (int i = 0; i < testScores.Length; i++) 
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "jesse", "adam", "anders", "anna", "amy" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(23);
            //testScores.Add(45);
            //testScores.Add(93);
            //testScores.Add(91);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "jesse", "mel", "andy", "ann" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 89, 96, 34, 97, 95 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
