using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        public class Employee
        {
            int ID;
            string Fname;
            string Lname;

            static void Main(string[] args)
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee { Fname = "Larry", Lname = "Tatlor", ID = 100 },
                    new Employee { Fname = "Joe", Lname = "Taylor", ID = 101 },
                    new Employee { Fname = "Bill", Lname = "Tater", ID = 102 },
                    new Employee { Fname = "Joe", Lname = "Travis", ID = 103 },
                    new Employee { Fname = "Sally", Lname = "Toots", ID = 104 },
                    new Employee { Fname = "Lori", Lname = "Terry", ID = 105 },
                    new Employee { Fname = "Mark", Lname = "Trace", ID = 106 },
                    new Employee { Fname = "Joe", Lname = "Todd", ID = 107 },
                    new Employee { Fname = "Jerry", Lname = "Tompson", ID = 108 },
                    new Employee { Fname = "Johnny", Lname = "Torry", ID = 109 },
                };

                foreach (Employee employee in employees)
                {
                    if (employee.Fname =="Joe")
                    {
                        
                    }
                }
            }
        }
    }
}
                
                    
    
