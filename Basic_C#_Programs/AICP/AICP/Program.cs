using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the salary program
            Console.WriteLine("Annonymouse Income Comparison Program");
            Console.ReadLine();
            // Collecting Person 1 information. 
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            string rate1 =Console.ReadLine();
            // Creating varibles for Person 1 
            decimal p1rate = Convert.ToDecimal(rate1);
            Console.WriteLine("Hours Worked per week?");
            string hours1 =Console.ReadLine();
            decimal p1hours = Convert.ToDecimal(hours1);

            // Collecting Person 2 information
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            // Creating varibles for Person 1 
            string rate2 = Console.ReadLine();
            decimal p2rate = Convert.ToDecimal(rate2);
            Console.WriteLine("Hours Worked per week?");
            string hours2 = Console.ReadLine();
            decimal p2hours = Convert.ToDecimal(hours2);

            //Performing multiplication for Person 1 Annual Salery

            decimal p1annualSalary = p1rate * p1hours * 52;
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(p1annualSalary);
            Console.ReadLine();

            //Performing multiplication for Person 2 Annual Salery

            decimal p2annualSalary = p2rate * p2hours * 52;
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(p2annualSalary);
            Console.ReadLine();

            //Comparison statement
           
            Console.WriteLine("Does Person 1 make more money than Person 2");
            bool annualDifference = p1annualSalary > p2annualSalary;
            Console.WriteLine(annualDifference);
            Console.ReadLine();


        }
    }
}
