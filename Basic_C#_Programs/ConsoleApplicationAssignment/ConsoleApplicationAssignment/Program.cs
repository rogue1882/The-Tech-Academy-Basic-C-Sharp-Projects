using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for a number and multiply by 50
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            int Mnumber = Convert.ToInt32(number); 
            int multiply = Mnumber * 50;
            Console.WriteLine(multiply);
            Console.ReadLine();

            //Asks for a number and adds 25 to it
            Console.WriteLine("Please enter a number");
            string number2 = Console.ReadLine();
            int addNumber = Convert.ToInt32(number2);
            int add = addNumber + 25;
            Console.WriteLine(add);
            Console.ReadLine();

            //Asks for a number and divides it by 12.5
            Console.WriteLine("Please enter a number");
            string number3 = Console.ReadLine();
            double divideNumber = Convert.ToDouble(number3); 
            double divide = divideNumber / 12.5;
            Console.WriteLine(divide);
            Console.ReadLine();

            //Asks for a number and number and validates if it is greater than 50
            Console.WriteLine("Please enter a number");
            string number4 = Console.ReadLine();
            int validateNumber = Convert.ToInt32(number4);
            bool validate = validateNumber > 50;
            Console.WriteLine(validate);
            Console.ReadLine();


            //Asks for a number and number and validates if it is greater than 50
            Console.WriteLine("Please enter a number");
            string number5 = Console.ReadLine();
            int remainderNumber = Convert.ToInt32(number5);
            int remainder = remainderNumber % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();




        }
    }
}
