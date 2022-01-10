
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    //Created Class Employee with inheritance from class Person
    public class Employee : Person
    {
        //Added property Id
        public int Id { get; set; }

        public override void SayName() 
        {
            {
                string FullName = FirstName + " " + LastName;
                Console.WriteLine(FullName);
                Console.ReadLine();
            }
;
        }
    }

    
}
