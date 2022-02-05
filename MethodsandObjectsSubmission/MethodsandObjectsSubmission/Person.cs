using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    public class Person
    {
        // Added properties
        public string FirstName { get; set;  }
        public string LastName { get; set;  }

        // Created method SayName
        public void SayName()
        {
            string FullName = FirstName +" " + LastName;
            Console.WriteLine(FullName);
            Console.ReadLine();
        }

        //Created method EmployeeName

        public string EmployeeName()
        {
            string FullName = FirstName + " " + LastName;
            return FullName;

        }

    }
}
