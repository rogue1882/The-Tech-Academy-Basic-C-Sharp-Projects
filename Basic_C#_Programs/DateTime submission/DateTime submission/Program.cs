using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting the time now!
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            //getting a number
            Console.WriteLine("Please enter a number. ");
            //Converting that number to a double
            double X = Convert.ToDouble(Console.ReadLine());

            //Creating DT1 
            DateTime DT1 = DateTime.Now;

            // Creating DT2
            DateTime DT2 = DT1.AddHours(X);


            //printing updated time to console.
            Console.WriteLine("The updated time is " + DT2.ToString());
            Console.ReadLine();

        }
    }
}
