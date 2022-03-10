using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your Age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Age);
            Console.ReadLine();

            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-Age);
            Console.WriteLine(newDate);
            Console.ReadLine();
        }
    }
}
