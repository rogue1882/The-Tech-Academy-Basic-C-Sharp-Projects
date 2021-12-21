using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jeff", "John", "Jimmy", "Jill", "Jennifer" };
            Console.WriteLine("What is your last name? ");
            string Lname = Console.ReadLine();
            Console.ReadLine();

            for (int i = 0; i < names.Length; i++)

            {
                names[i] += " " + Lname;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();

            int[] num1 = { 10, 25, 53, 25, 17, 83, 100 };

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] < 25)
                {
                    Console.WriteLine(num1[i]);
                }

                Console.ReadLine();


            }

            int[] num2 = { 10, 25, 53, 25, 17, 83, 100 };

            for (int i = 0; i < num2.Length; i++)
            {
                if (num2[i] <= 25)
                {
                    Console.WriteLine(num2[i]);
                }

                Console.ReadLine();
            }

            string[] cars1 = { "ford", "chevy", "mustang", "chevelle", "corvert", "toyota" };
            Console.WriteLine("What is your car?");
            string myCar1 = (Console.ReadLine());

            for (int J = 0; J < cars1.Length; J++)
            {
                if (cars1[J] == myCar1)
                {
                    Console.WriteLine("Your car is in this list");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Your car is not on this list");
                    Console.ReadLine();
                    break;
                }
            }

            List<string> cars = new List<string>() { "ford", "chevy", "mustang", "chevelle", "corvert", "toyota", "ford" };
            Console.WriteLine("What is the make of your car?");
            string myCar = (Console.ReadLine());
            if (cars.Contains(myCar))
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (myCar == cars[i])

                    {
                        Console.WriteLine("your car is listed at index " + i);

                    }
                }
            }
            else
            {
                Console.WriteLine("Your car is not on the list");

            }

            Console.ReadLine();

            List<string> dupeCars = new List<string>();
            foreach (string car in cars) { 

                if (myCar == car)
                {
                    if (dupeCars.Contains(car))
                    {
                        Console.WriteLine("This car is a duplicate " + car);
                    }
                    dupeCars.Add(car);
                }
        } Console.ReadLine();
    





        }
    }
}
