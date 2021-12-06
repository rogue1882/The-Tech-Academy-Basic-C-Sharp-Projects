using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int yourAge = Convert.ToInt32(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string DUI = Console.ReadLine();
            bool okDUI = Convert.ToBoolean(DUI);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(tickets);
            Console.ReadLine();

            bool ofAge = yourAge > 15;
            bool noDUI = (okDUI == false);
            bool okTickets = speedingTickets < 3;

            Console.WriteLine("Qualified?");
            bool qualified = (ofAge &&  okTickets && noDUI );
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
