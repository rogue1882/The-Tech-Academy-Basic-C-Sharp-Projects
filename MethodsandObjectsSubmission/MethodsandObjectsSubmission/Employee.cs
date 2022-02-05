using System;

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

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return true;
            
            
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return false;

        }
        
    }

}
