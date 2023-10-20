using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class ActivityGenerator
    {      
        internal void GenerateActivity()
        {
            Console.Write("Connecting to the database");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine();
            Console.Write("Choosing your random activity");

            for (int i = 0; i < 9; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine();

            Random rng = new Random();


            int randomNumber = rng.Next(ActivityList.activities.Count);
            string randomActivity = ActivityList.activities[randomNumber];

            if (GetInfo.yourAge < 21 && randomActivity == "Wine Tasting")
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine("Trying something else!");

                ActivityList.activities.Remove(randomActivity);

                GenerateActivity();
                
            }

            else
            {
                DisplayActivity();
            }

             void DisplayActivity()
            {
                Console.WriteLine($"Ah got it! {GetInfo.yourName}, your random activity is: {randomActivity}!");
                Console.WriteLine();
                Console.WriteLine("Is this ok or do you want to grab another activity? Keep/Redo: ");

                var keepOrNot = Console.ReadLine().ToLower();

                if (keepOrNot.StartsWith("k"))
                {
                    Console.WriteLine($"Awesome! Enjoy {randomActivity}!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit.");
                    GetInfo.exit = true;
                }

                else if (keepOrNot.StartsWith("r"))                 
                {
                    GenerateActivity();
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter 'keep' or 'redo'.");
                    Console.WriteLine();

                }

            }

        }
    }
}
