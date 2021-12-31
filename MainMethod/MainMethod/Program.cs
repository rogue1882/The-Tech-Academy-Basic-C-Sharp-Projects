using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //request user input
            Console.WriteLine("Please enter a number. ");
            {
                //Convert to integer
                int userNum = Convert.ToInt32(Console.ReadLine());

                //Calling the add method
                Console.WriteLine(Submission.AddNumber(userNum));

                //Calling the decimal subtraction method
                Console.WriteLine(Submission.addNumber(userNum));

                //Calling the String method
                Console.WriteLine(Submission.AddNumber(userNum));
            }
            Console.ReadLine();
        }
    }
}
