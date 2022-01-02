using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        //public static int Num2 { get; private set; }
        //public static int userNum { get; private set; }

        public static void Main(string[] args)
        {
            //request user input
            Console.WriteLine("Please enter a number. ");
            {
                //Convert to integer
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add a second number.");

                //Convert to integer
                int Num2 = Convert.ToInt32(Console.ReadLine());

                //calling void method
                Console.WriteLine(Test.TestNumber(userNum, Num2));

                //request user to give a second int input or let computer pick random int
                //Console.WriteLine("Would you like to enter another number? Yes or No");
                //bool Yes = Convert.ToBoolean(Console.ReadLine());
                // if (Yes != true)
                //    {
                //    Console.WriteLine("The computer picks number 12");
                //    int Num2 =  12;
                //    }


                // Calling Method AddNumber
                //Console.WriteLine(takeTwo.AddNumber(userNum, Num2));

            }
            Console.ReadLine();
        }
        
    }
}
