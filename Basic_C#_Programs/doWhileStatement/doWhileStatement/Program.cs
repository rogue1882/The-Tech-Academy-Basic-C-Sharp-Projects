using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your employee number?");
            int ID = Convert.ToInt32(Console.ReadLine());
            bool employID = ID == 8664;

            do
            {

                switch (ID)
                {
                    case 1001:
                        Console.WriteLine("Employee not authorized. Try again.");
                        Console.WriteLine("What is your employee number?");
                        ID = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2005:
                        Console.WriteLine("Employee not authorized. Try again.");
                        Console.WriteLine("What is your employee number?");
                        ID = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6776:
                        Console.WriteLine("Employee not authorized. Try again.");
                        Console.WriteLine("What is your employee number?");
                        ID = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8664:
                        Console.WriteLine(" You may enter");
                        employID = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("What is your employee number?");
                        ID = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!employID);

            Console.ReadLine();

            Console.WriteLine("Enter your pin.");
            int pin = Convert.ToInt32(Console.ReadLine());
            bool myPin = pin == 1050;
            
            while (pin != 1050)
            switch (pin)
            {
                case 1001:
                    Console.WriteLine("Wrong, Please enter your pin");
                    Console.WriteLine("Enter your pin.");
                    pin = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2000:
                    Console.WriteLine("You are not authorised at this door.  Please go to the front door");
                    Console.WriteLine("Enter your pin.");
                    pin = Convert.ToInt32(Console.ReadLine());
                    break;
                 case 1050:
                     Console.WriteLine("Access granted to IT Offices");
                     myPin = true;
                     break;
                 default:
                    Console.WriteLine("Please report to HR through the main door");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                            
                }
            Console.ReadLine();
           

        }
    }
}
