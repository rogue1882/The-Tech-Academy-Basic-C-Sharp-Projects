using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionNew
{
    public class Reservation
    {
        


        public Reservation()
        {
          

        }

        public Reservation(object name)
        {
            this.Name = name;
        }

        public object Name { get; }
    }
}
