using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionNew
{
    public class Reservation
    {
        public string Name;
        public string ID;

        public Reservation()
        {

        }

        public Reservation(string id) : this("John", id)
        {
        }

        public Reservation( string name, string id)
        {
            this.ID = id;
            this.Name = name;
        }

        
        
    }
}
