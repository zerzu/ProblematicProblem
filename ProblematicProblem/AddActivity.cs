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
        internal bool addToList;
        internal void ActivityAdder(bool addResponse)
        {
            while (addToList)               //fix this shit it sucks balls
            {
                Console.Write("What would you like to add? ");
                
                string input = Console.ReadLine();

                if (input is string)
                {
                    RandomActivity.activities.Append(input);
                }                

                else
                {
                    Console.WriteLine("Invalid input. Please enter an activity to add");
                    Console.WriteLine();
                    ActivityAdder(true);
                }
                

                foreach (var activity in RandomActivity.activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");      // input validation and call a method

                
            }
        }
    }
}