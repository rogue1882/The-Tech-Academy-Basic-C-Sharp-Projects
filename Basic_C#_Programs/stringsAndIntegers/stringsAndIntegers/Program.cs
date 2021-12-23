using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // try statement to test loop
            try
            {
                // Block creates lista and ask user for a number to divide by
                // converts the  string to int and the iterates through the list
                //displays all indexes divided on screen
                List<int> num1 = new List<int> { 1, 2, 15, 200, 583, 1882 };
                Console.WriteLine("Enter number to divide by.");
                int divider = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num1.Count; i++)
                {
                    Console.WriteLine(num1[i] / divider);
                }

            }
                //Catch block for type errors
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a  whole number");
                
            }
                //Catch block for zeros
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
                //Catch block for other exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

                //Close out with display
            finally
            {
                Console.WriteLine("You have emerged from a try/catch block and continued on with program execution");
                Console.ReadLine();
            }
        }
            
    }
}
