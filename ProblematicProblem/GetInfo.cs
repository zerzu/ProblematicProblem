using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    internal class GetInfo
    {
        internal static bool exit = false;

        internal static int yourAge;

        internal static string yourName;

        static bool realAge = false;
        internal static void Prompt()
        {
            Console.WriteLine("Hello, welcome to the random activity generator!");
            Console.Write("Would you like to generate a random activity? yes/no: ");

            var input = Console.ReadLine().ToLower();

            if (input.StartsWith("y"))
            {
                Console.WriteLine();
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
            string input = Console.ReadLine();

            Regex regex = new Regex(@"^[a-zA-Z\s]+$");

            if (!string.IsNullOrEmpty(input) && regex.IsMatch(input))
            {
                yourName = input;
            }
            else
            {
                Console.WriteLine("Invalid input. Please only use characters");
                Console.WriteLine();
                UserInfo();

            }            
            
            do
            {
                Console.Write("What is your age? ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out yourAge)) 
                {
                    realAge = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid age");
                }

            } while (!realAge);

            var startActivity = new ActivityList();

            startActivity.SeeActivity();

        }
    }
}
