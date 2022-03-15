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

            //Chaining constructors with an ID and no name.
            Reservation reservation1 = new Reservation("3");
            Console.WriteLine(reservation1.Name + " " + reservation1.ID);
         
            Console.ReadLine();

           

            


           


        }
        
    }
}
