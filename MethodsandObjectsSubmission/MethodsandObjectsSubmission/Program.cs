using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 12;
            employee.SayName();

            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 11;
            employee1.SayName();

            Employee employee2 = new Employee();
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.Id = 12;
            employee2.SayName();

            //IQuittable quitter = new Employee();
            //employee.Quit(employee);
            //employee.Id = 12;

            Console.WriteLine(employee == employee2);
            Console.ReadLine();

            Console.WriteLine(employee == employee1);
            Console.ReadLine();

        }

    }
}
