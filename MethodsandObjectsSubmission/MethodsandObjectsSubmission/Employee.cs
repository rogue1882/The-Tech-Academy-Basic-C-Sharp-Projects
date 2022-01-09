using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    //Created Class Employee with inheritance from class Person
    // Added an Interface IQuitable
    public class Employee : Person, IQuittable
    {
        //Added property Id
        public int Id { get; set; }

        public void Quit(Employee employee)
        {
            Console.WriteLine("This employee has Quit");
            Console.ReadLine();

        }
    }

}
