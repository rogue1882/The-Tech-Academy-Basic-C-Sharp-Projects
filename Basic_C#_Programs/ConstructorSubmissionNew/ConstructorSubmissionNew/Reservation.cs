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

        public Reservation(string ID) : this(name: ID)
        {
            Name = Name;
        }

        public Reservation( string name = "", string ID = "")
        {
            this.ID = ID;
            this.Name = Name;
        }

        
        
    }
}
