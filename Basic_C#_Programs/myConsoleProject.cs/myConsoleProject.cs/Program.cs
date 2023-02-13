using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {

            //console.writeline("what is your name");
            //string yourname = console.readline();
            //console.writeline("your name is " + yourname);
            //console.readline();

            //Console.WriteLine("what is your favorite number");
            //string FavoriteNumber = Console.ReadLine();
            //Console.WriteLine("your favorite number is: " + FavoriteNumber);
            //Console.ReadLine();

            Console.WriteLine("Pitman");

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Student Daily report");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("What course are you in");
            String Course = Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("what page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("you're on page " + pageNumber + "?");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Do you need any help? please answer 'true' or 'false'");
            String needHelp = Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            bool helpRequired;
            if (needHelp == "true")
            {
                Console.WriteLine("Perfect, how can i help?");
            }
            else
            {
                Console.WriteLine("Alright. You can always come back to us if you need help");
            }

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("were there any positive experiences you'd like to share? Please provide specifics");
            string Experience = Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Is there any other feedback you'd like to provde? Please be Specific");
            string Feedback = Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("how many hours did you study today?");
            string hoursStudied = Console.ReadLine();

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Thank you! \nAn instructor will respond shortly. Have a great day!");
        }
    }
}
