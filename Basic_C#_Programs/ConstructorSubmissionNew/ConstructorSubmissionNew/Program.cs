using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionNew
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Adding Constant to program. 
            const string hotelName = "Grand Budepest Inn";

            // Creating opening statement and question
            Console.WriteLine("Welcome to {0}.  Would you like to make a reservation?", hotelName);
            Console.ReadLine();
             
            //getting information for reservation
            Console.WriteLine("What name would you like the reservation under?");
            string Name = (Console.ReadLine());
            var reservation = new Reservation( Name );
         ;

            Console.WriteLine("Please enter ID?");
            string ID = Console.ReadLine();

            var reservation2 = new Reservation(ID, Name);
            Console.WriteLine("Your reservation at the {0} for {1} with ID {2} is approved ", hotelName, Name, ID);
         
            Console.ReadLine();


            


           


        }
        
    }
}
