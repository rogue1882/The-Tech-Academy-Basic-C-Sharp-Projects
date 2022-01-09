using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person
    {
        // Added properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Created method SayName
        public virtual void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);
            Console.ReadLine();
        }

    }
}