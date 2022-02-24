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

            public static void Main(string[] args)
            {
                //Created List of Employees
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

                List<Employee> joeList = employees.Where(X => X.ID > 105).ToList();
                Console.WriteLine(joeList);
                Console.ReadLine();

                // List<Employee> joeList = employees.Where(x => x.Fname == Fname.).Tolist();

                // Created Joe list
                //List<Employee> joeList = new List<Employee>();





                // Foreach loop to seperate Joe out to new List
                // foreach (Employee employee in employees)
                //{
                //    if (employee.Fname == "Joe")
                //    {
                //        joeList.Add(employee);
                //    }
                //}

                //foreach loop to print joeList
                //foreach (Employee emp in joeList)
                //{
                //Console.WriteLine(emp.Fname + " " + emp.Lname + " " + emp.ID);
                //Console.ReadLine();

                //}


            }
        }
    }
}
                
                    
    
