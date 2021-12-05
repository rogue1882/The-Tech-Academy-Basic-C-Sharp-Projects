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
            //Opening statement
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //Asking for input of student name and printing hello message
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();

            //Requsting course information and sending it back to user
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("you are in " + course + "!");
            Console.ReadLine();

            //Requesting page numbers and sending it back to user.
            //Kept a simple string since only displaying
            Console.WriteLine("What page number are you on?");
            string number = Console.ReadLine();
            Console.WriteLine("you are on page number " + number + "!");
            Console.ReadLine();

            //Asking if user needs help and returning their answer.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            Console.WriteLine("you answered " + help);
            Console.ReadLine();

            //Requested any positive experiances and returned answer for user to see.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string share = Console.ReadLine();
            Console.WriteLine( "Positive Experiences " + share);
            Console.ReadLine();

            //Requested any other feedback and returned to user. 
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback of " + feedback);
            Console.ReadLine();

            //Requested hours of study and returned to user. 
            Console.WriteLine("How many hours did you study today");
            string hours = Console.ReadLine();
            Console.WriteLine("Hours studied " + hours);
            Console.ReadLine();

            //Closing message
            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly");
            Console.WriteLine("Have a great day");
            Console.ReadLine();


        }
    }
}
