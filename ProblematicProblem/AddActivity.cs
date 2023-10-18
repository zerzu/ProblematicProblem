using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class AddActivity
    {
        internal static bool addToList;
        internal void ActivityAdder(bool activityAdd)
        {
            while (addToList)               //fix this shit
            {
                Console.Write("What would you like to add? ");
                
                string input = Console.ReadLine();

                if (input is string)
                {
                    RandomActivities.activities.Add(input);
                }                

                else
                {
                    Console.WriteLine("Invalid input. Please enter an activity to add");
                    Console.WriteLine();

                   ActivityAdder(true);
                }
                

                foreach (string activity in RandomActivities.activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");

                addToList = bool.Parse(Console.ReadLine());
            }
        }
    }
}