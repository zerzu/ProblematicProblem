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

            if (input.StartsWith("y") || input.StartsWith("s"))
            {                
                {
                    foreach (var activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");

                    var generate = Console.ReadLine().ToLower();

                   

                    if (generate.StartsWith("y"))
                    {
                    }
                    else if (input.StartsWith("n"))
                    {
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                        Console.WriteLine();                        
                    }


                }

                else if (input.StartsWith("n"))
            {
                Console.WriteLine("Okay, have a great day!");       //fix this to instantiate not list activities method

            }

            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine();
                SeeActivity(true);
            }
            
               
            }

            
        }
    }
}
