using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcom message
            Console.WriteLine("Welcome to Package Express.  Please follow instructions below.");
            Console.ReadLine();

            //getting package weight
            Console.WriteLine("How much does your package weigh?");
            string box = (Console.ReadLine());
            // converting to an integer
            int bWeight = Convert.ToInt32(box);
            //validating weight is not excessive
            if (bWeight > 50)
            {
                //Exit statement for excess weight
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }
         
            // getting addtional information to determin if over size
            Console.WriteLine("Please enter your package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            //validating size
            if (width + height + length > 50)
            {
                //exit statement if oversize
                Console.WriteLine("Package to big to be shipped via Package Express.  Have a nice day");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Calculating cost of shipping
            int product = (width * height * length);
            int overall = (product * bWeight);
            int final = (overall / 100);
            decimal cost = Convert.ToDecimal(final);

            //returning cost of shipping
            Console.WriteLine("Your estimated total for shipping this package is: $" + cost + " Thank You");
            Console.ReadLine();
        }
    }
}
