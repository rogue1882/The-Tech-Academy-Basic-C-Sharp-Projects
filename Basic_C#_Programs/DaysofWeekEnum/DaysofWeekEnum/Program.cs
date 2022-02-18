using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysofWeek
{
    public class Program

        //Create enum
    {
        public enum EDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {
            //Create try block
            try
            {
                Console.WriteLine(" What day of this week is it?");
                EDay pickDay = (EDay)Enum.Parse(typeof(EDay), Console.ReadLine(), true);
                Console.WriteLine("The day you picked was {0}", pickDay -0);
                Console.ReadLine();
            }
            //Create catch block that repeats try line. 
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual numerical day of the week.");
                EDay pickDay = (EDay)Enum.Parse(typeof(EDay), Console.ReadLine(), true);
                Console.WriteLine("The day you picked was {0}", pickDay - 0);
                Console.ReadLine();
            }
        }

    }
}

