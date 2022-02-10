using System;
using static MethodsandObjectsSubmission.Employee;

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

        public static bool operator ==(Id employee , Id employee2)
        {
            return true;
        }

        public static bool operator !=(Id employee , Id employee2)
        {
            return false;
        }

        public class Id
        {
        }
    }

}
