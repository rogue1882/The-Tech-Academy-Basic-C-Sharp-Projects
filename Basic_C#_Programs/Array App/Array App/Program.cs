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
              Console.WriteLine(names[i]);
            }

            Console.ReadLine();


        }
    }
}
