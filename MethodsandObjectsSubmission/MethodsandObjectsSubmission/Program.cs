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
            employee.FirstName = "Joe";
            employee.LastName = "Smith";
            employee.Id = 11;
            employee.SayName();

            Employee employee2 = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 12;
            employee.SayName();

            //IQuittable quitter = new Employee();
            //employee.Quit(employee);
            //employee.Id = 12;


        } 
       



       
       
    }
}
