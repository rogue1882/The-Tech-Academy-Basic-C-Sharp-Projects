using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sumission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a String Array
            string[] word1 = { "Kill", "Roy", "Was", "Here", "In", "1941" };

            //Asked user to inpit index number
            Console.WriteLine("Please inter index number.");

            //Converted string to int
            int num = Convert.ToInt32(Console.ReadLine());

            //Validated index input and provided response
            if (num <= 5)
            {
                Console.WriteLine(word1[num]);
                Console.ReadLine();
            }
            else
            //response if no index information exists
            {
                Console.WriteLine("No such index exisits.");
                Console.ReadLine();
            }


            //Created a Integer Array
            int[] unit1 = { 1, 8, 2, 75, 101, 227};

            //Asked user to inpit index number
            Console.WriteLine("Please inter index number.");

            //Converted string to int
            int numUnit = Convert.ToInt32(Console.ReadLine());

            //Validated index input and provided response
            if (numUnit <= 6)
            {
                Console.WriteLine(unit1[numUnit]);
                Console.ReadLine();
            }
            //response if no index information exists
            else
            {
                Console.WriteLine("No such index exisits.");
                Console.ReadLine();
            }


            //Created a String List
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Rosie");
            intList.Add("How");
            intList.Add("are");
            intList.Add("you");

            //Asked user to inpit index number
            Console.WriteLine("Please inter index number.");

            //Converted string to int
            int numList = Convert.ToInt32(Console.ReadLine());

            //Validated index input and provided response
            if (numList <= 5)
            {
                Console.WriteLine(intList[numList]);
                Console.ReadLine();
            }
            //response if no index information exists
            else
            {
                Console.WriteLine("No such index exisits.");
                Console.ReadLine();
            }
        }
    }
}
