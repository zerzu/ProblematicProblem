using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class GetInfo
    {
        public string userName { get; set; }
        public int auserAge { get; set; } = 0;

        

        
        internal static bool exit = false;
        internal static bool view = false;

        internal static void Prompt()
            
        {
            Console.WriteLine("Hello, welcome to the random activity generator!");
            Console.Write("Would you like to generate a random activity? yes/no: ");

            var input = Console.ReadLine().ToLower(); 

            if (input.StartsWith("y"))
            {
                UserInfo();
            }
            else if (input.StartsWith("n"))
            {
                Console.WriteLine("Okay, have a great day!");
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine();
                Prompt();
            }            
        }

        internal static void UserInfo() 
        { 
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();                               //TODO Add input validation
            Console.WriteLine();

            Console.Write("What is your age? ");                                //TODO Add input validation
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var newActivity = new RandomActivities();

            newActivity.SeeActivity(true);

        }
    }
}
