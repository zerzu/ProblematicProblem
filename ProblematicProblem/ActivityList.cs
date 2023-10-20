using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class ActivityList
    {
        internal static List<string> activities = new List<string>()
        {
            "Movies", "Paintball", "Bowling", "Lazer Tag",
            "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"
        };

        internal static bool listActivity;
        internal static bool addActivity;
        internal void SeeActivity()
        {
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");

            var input = Console.ReadLine().ToLower();

            if (input.StartsWith("y") || input.StartsWith("s"))     
            {
                Console.WriteLine();

                Console.WriteLine("Activity List");
                Console.WriteLine($"-------------");

                foreach (var activity in activities)
                {
                    Console.Write($"||{activity}");
                    Thread.Sleep(250);
                }

                Console.Write($"||");

                Console.WriteLine();

                ActivityAdd();

            }

            else if (input.StartsWith("n"))
            {
                ActivityAdd();
            }

            else
            {
                Console.WriteLine("Invalid input, please enter 'yes' or 'no'");
                Console.WriteLine();

                SeeActivity();
            }

        }

        public void SeeActivity(ActivityList activityList)
        {
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");

            var input = Console.ReadLine().ToLower();

            if (input.StartsWith("y") || input.StartsWith("s"))
            {
                Console.WriteLine();

                Console.WriteLine("Activity List");
                Console.WriteLine($"-------------");

                foreach (var activity in activities)
                {
                    Console.Write($"||{activity}");
                    Thread.Sleep(250);
                }

                Console.Write($"||");

                Console.WriteLine();

                ActivityAdd();

            }

            else if (input.StartsWith("n"))
            {
                ActivityAdd();
            }

            else
            {
                Console.WriteLine("Invalid input, please enter 'yes' or 'no'");
                Console.WriteLine();

                SeeActivity();
            }

        }

        internal void ActivityAdd()
        {           

            Console.WriteLine("Would you like to add any activities before we generate one? yes/no: ");

            var generate = Console.ReadLine().ToLower();

            if (generate.StartsWith("y"))
            {
                AddActivity yourActivity = new AddActivity();

                yourActivity.ActivityAdder();
            }

            else if (generate.StartsWith("n"))
            {
                ActivityGenerator generatedActivity = new ActivityGenerator();

                generatedActivity.GenerateActivity();
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine();
                ActivityAdd();
            }

        }
    }



        
}
