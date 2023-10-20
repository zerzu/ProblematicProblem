using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class AddActivity
    {
        internal void ActivityAdder()
        {

            Console.WriteLine("What would you like to add?");
            Console.WriteLine("Please do not enter any numbers or special characters.");
            Console.Write("Activity: ");

            string input = Console.ReadLine();

            Regex regex = new Regex(@"^[a-zA-Z\s]+$");

            if (!string.IsNullOrEmpty(input) && regex.IsMatch(input))
            {
                ActivityList newActivityList = new ActivityList();

                ActivityList.activities.Add(input);

                newActivityList.SeeActivity(newActivityList);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an activity to add");
                Console.WriteLine();
                ActivityAdder();
            }

        }
    }
}