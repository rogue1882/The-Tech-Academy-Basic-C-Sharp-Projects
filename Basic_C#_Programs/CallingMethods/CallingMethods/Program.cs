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
            Console.WriteLine("Please enter a number bluecar packs you would like to order.");
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }
        }

    }


        public static void ModelCar(int BlueCarPacks)
        {
           

                int Num1 = Convert.ToInt32(Console.ReadLine());
                int Num3 = BlueCarPacks * Num1;


                Console.WriteLine("You have chosen " + Num3 + "is this correct?");
                Console.ReadLine();
            
            
        }
        
        
    }
    
}
    

