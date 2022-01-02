using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.WriteLine("Please enter a number ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Calling the single parameter user added method
            Console.WriteLine(Numbers.DivideNumber(userNum));
            Console.ReadLine();

            //second user input
            Console.WriteLine("please add a new number.");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            //Call the divide method with 2 user supplied parameters
            Console.WriteLine(Numbers.DivideNumber(Numbers.DivideNumber(userNum, Num2)));
            Console.ReadLine();

            //Method with output parameters
            string numberAsString = "1882";


            if (Int32.TryParse(numberAsString, out var number))
                Console.WriteLine($"Converted '{numberAsString}' to {number}");
            else
                Console.WriteLine($"Unable to convert '{numberAsString}'");
            / 
            Console.ReadLine();
        }

    }
}
