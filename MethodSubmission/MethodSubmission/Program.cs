using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        public static int userNum { get; private set; }


        //public static int Num2 { get; private set; }
        //public static int userNum { get; private set; }

        public static void Main(string[] args)
        {
             try
            {
                Console.WriteLine("Pick a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please pick a 2nd number if you would like.");
                int Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(takeTwo.AddNumber(userNum, Num2));
                
                
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine(takeTwo.AddNumber(userNum));
                
            }
            finally

            {
                Console.ReadLine();
            }
            //request user input
            //Console.WriteLine("Please enter a number. ");
            //{
            //Convert to integer
            //int userNum = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Add a second number.");

            //Convert to integer
            //int Num2 = Convert.ToInt32(Console.ReadLine());

            //calling void method
            //Console.WriteLine(Test.TestNumber(userNum, Num2));


            //    {
            //        Console.WriteLine("The computer picks number 12");
            //        int Num2 = 12;

            //        //Calling Method AddNumber
            //        Console.WriteLine(takeTwo.AddNumber(userNum, Num2));
            //    }




            //}
            //Console.ReadLine();
        }
        
    }
}
