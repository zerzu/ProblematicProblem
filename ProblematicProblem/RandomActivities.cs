using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class RandomActivities
    {
        internal static List<string> activities = new List<string>()
        {
            "Movies", "Paintball", "Bowling", "Lazer Tag",
            "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"
        };

        public static bool listActivity;
        internal static bool addActivity;
        public void SeeActivity(bool listActivity)
        {
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");

            var input = Console.ReadLine().ToLower();

            if (input.StartsWith("y") || input.StartsWith("s"))
            {
                foreach (var activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();

                ToAdd(true);
            }
        }    
        internal void ToAdd(bool addMore)
        {
            Console.Write("Would you like to add another activity before we generate one? yes/no: "); //Implement Add boolean

            var generate = Console.ReadLine().ToLower();


            if (generate.StartsWith("y"))
            {
                var userActivity = new AddActivity();
                userActivity.ActivityAdder(true);               //TODO this is where we call AddActivity
            }
            else if (generate.StartsWith("n"))
            {
                var userActivity = new ActivityGenerator();
                // userActivity.                                   //TODO Call activity generator
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine();
                ToAdd(true);
            }
        }

                
            


        


    }
}

