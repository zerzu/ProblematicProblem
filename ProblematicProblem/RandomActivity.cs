using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class RandomActivity
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

            if (input.StartsWith("y") || input.StartsWith("s"))     //need to fix input validation here for no answer and else
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

            }

            Console.WriteLine();                                //Start Here Dummy

            Console.WriteLine("Would you like to add any activities before we generate one? yes/no: ");

            var generate = Console.ReadLine().ToLower();    // need to implement methods to pass this into



            if (generate.StartsWith("y"))
            {
                Console.WriteLine("yes chosen");
            }

            else if (input.StartsWith("n"))
            {
                Console.WriteLine("no chosen");
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine();
            }



        }
    }
}
