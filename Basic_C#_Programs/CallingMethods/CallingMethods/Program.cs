using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //request user input
            Console.WriteLine("Please enter a number. ");
            {
                //Convert to integer
                int userNum = Convert.ToInt32(Console.ReadLine());

                //Calling the add method
                Console.WriteLine(Numbers.AddNumber(userNum));
                
                //Calling the subtraction method
                Console.WriteLine(Numbers.SubNumber(userNum));

                //Calling the multiply method
                Console.WriteLine(Numbers.MultiplyNumber(userNum));
            }
            Console.ReadLine();
        }


        
        
        
    }
    
}
    

