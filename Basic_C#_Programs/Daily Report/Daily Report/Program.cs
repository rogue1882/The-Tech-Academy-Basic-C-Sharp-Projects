using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("you are in " + course + "!");
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string number = Console.ReadLine();
            Console.WriteLine("you are on page number " + number + "!");
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            Console.WriteLine("you answered " + help);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string share = Console.ReadLine();
            Console.WriteLine( "Positive Experiences " + share);
            Console.ReadLine();


            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback of " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today");
            string hours = Console.ReadLine();
            Console.WriteLine("Hours studied " + hours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly");
            Console.WriteLine("Have a great day");
            Console.ReadLine();


        }
    }
}
