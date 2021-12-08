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
        }
    }
}
