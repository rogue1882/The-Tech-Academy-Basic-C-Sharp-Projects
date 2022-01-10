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

            IQuittable quitter = new Employee();
            employee.Quit(employee);
            employee.Id = 12;


        } 
       



       
       
    }
}
